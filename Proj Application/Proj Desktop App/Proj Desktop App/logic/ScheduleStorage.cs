using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Proj_Desktop_App.dataAccess;
using System.IO.Pipes;

namespace Proj_Desktop_App
{
    public class ScheduleStorage
    {
        private List<AssignedShift> allAssignedShifts;
        private List<Availability> allAvailableShifts;
        private EmployeeStorage empStorage;
        private ScheduleManagement schManagement;
        public ScheduleStorage(EmployeeStorage empStorage)
        {
            this.empStorage = empStorage;
            schManagement = new ScheduleManagement();
            allAssignedShifts = new List<AssignedShift>();
            allAvailableShifts = new List<Availability>();

            allAssignedShifts.AddRange(schManagement.LoadAssignedShifts(DateTime.Now, empStorage));
            allAvailableShifts.AddRange(schManagement.LoadAvailability(empStorage));
        }
        /// <summary>
        /// Specify the day and Department then return list of employee's information
        /// </summary>
        /// <param name="time"> DateTime</param>
        /// <returns></returns>
        public string[] GetEmployeesInfoByDateAndDepartment(DateTime time,Departments departments)
        {
            List<string> temp = new List<string>();
            foreach (AssignedShift e in allAssignedShifts)
            {               
                if (e.Date.ToString("yyyy-MM-dd") == time.ToString("yyyy-MM-dd") &&e.Employee.GetDepartment()== departments)
                {
                    temp.Add($"{e.Employee.ToString()} Shift:{e.GetShiftTypeToString()} {e.Date.ToString("dddd, dd MMMM")}");
                }
            }
            return temp.ToArray();
        }
        /// <summary>
        /// Get list of BSN , Date, Shiftype Then Assigned the shift
        /// </summary>
        /// <param name="shiftType"></param>
        /// <param name="date"></param>
        /// <param name="bsn"></param>
        /// <returns></returns>
        public bool AssignShift(ShiftType shiftType, DateTime date, List<int> bsns)
        {
           try
            {
                ReloadSchedule(date); 
                foreach (int i in bsns)
                {
                    if (!AssignShift(date, i, shiftType))
                    {
                        string temp = "It's over " + empStorage.GetEmployee(i).ToString() + "'s FTE";                       
                        MessageBox.Show(temp);
                    }
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            UpDateAssignedShiftToSchdule();
            ReloadSchedule(date);
            return true;
        }
        /// <summary>
        /// Specify the date, shifttype and employee's bsn, the function will assigned the shift 
        /// in the mean time it will check the employee's fte to make sure the shift hours are not over their fte 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="bsn"></param>
        /// <param name="shiftType"></param>
        /// <returns></returns>
        private bool AssignShift(DateTime date,int bsn , ShiftType shiftType)
        {
            //1.Get Employee
            Employee employee = empStorage.GetEmployee(bsn);
            //2.Get employee's Assigned shift list for the week
            List<AssignedShift> current_week_shift_list_for_the_employee = GetEmployee_Assigned_Shift_For_The_Week(date, employee);           
            bool havetheshift = false;
            //3.if have the shift
            foreach (AssignedShift e in current_week_shift_list_for_the_employee)
            {
                if (e.Date.ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
                {   //4.update the shift type
                    e.UpDateShiftType(shiftType);
                    havetheshift = true;
                    break;
                }
            }
            if(havetheshift==false)
            {
                AssignedShift x = new AssignedShift(employee, date, shiftType);
                current_week_shift_list_for_the_employee.Add(x);
            }
            //Calculate the work hours after assgined shift
            int after_assigned_shift_workhours = 0;
            foreach (AssignedShift assigned in current_week_shift_list_for_the_employee)
            {
                switch (assigned.ShiftType)
                {
                    case ShiftType.Morning:
                    case ShiftType.Afternoon:
                    case ShiftType.Evening:
                        after_assigned_shift_workhours += 4; break;
                    case ShiftType.Morning_Afternoon:
                    case ShiftType.Afternoon_Evening:
                    case ShiftType.Morning_Evening:
                        after_assigned_shift_workhours += 8; break;
                }
            }          
            if (after_assigned_shift_workhours <= employee.GetFTE() * 40)
            {
                bool haverecords = false;
                foreach (AssignedShift e in allAssignedShifts)
                {
                    if (e.Date.ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
                    {
                        if (e.Employee.GetBSN() == employee.GetBSN())
                        {
                            e.UpDateShiftType(shiftType);
                            schManagement.ChangeShiftType(shiftType,employee.GetBSN(),date);  
                            haverecords = true;
                            return true;
                        }
                    }
                }
                if (haverecords == false)
                {
                    AssignedShift x = new AssignedShift(employee, date, shiftType);
                    //allAssignedShifts.Add(x);
                    schManagement.AddNewShift(shiftType, employee.GetBSN(),date);       
                    return true;
                }
            }           
               return false; 
        }
        /// <summary>
        /// specify the date and list of employee's bsn, it will remove the shift from the day 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="bsns"></param>
        /// <returns></returns>
        public bool RemoveShift(DateTime date, List<int> bsns)
        {
            try
            {
                List<Employee> emp = new List<Employee>();
                foreach (int i in bsns)
                {
                    emp.Add(empStorage.GetEmployee(i));
                }
                List<AssignedShift> temp = new List<AssignedShift>();
                foreach (AssignedShift e in allAssignedShifts)
                {
                    if (e.Date.ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
                    {
                        temp.Add(e);
                    }
                }
                foreach (Employee e in emp)
                {
                    foreach (AssignedShift b in temp)
                    {
                        if (b.Employee.GetBSN() == e.GetBSN())
                        {
                            //allAssignedShifts.Remove(b);
                            schManagement.RemoveAssignedShift(e.GetBSN(),date);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            UpDateAssignedShiftToSchdule();
            ReloadSchedule(date);
            return true;
        }
        /// <summary>
        /// Update Current list of Shift information form Schdule Class
        /// </summary>
        /// <param name="date"></param>
        public void ReloadSchedule(DateTime date)
        {
            allAssignedShifts.Clear();
            allAvailableShifts.Clear();
            allAssignedShifts.AddRange(schManagement.LoadAssignedShifts(DateTime.Now, empStorage));
            allAvailableShifts.AddRange(schManagement.LoadAvailability(empStorage));
        }
        /// <summary>
        /// Update the shift changes to the Schdule Class 
        /// </summary>
        private void UpDateAssignedShiftToSchdule()
        {
            string updatefeedback = schManagement.UpdateAssignmentShift();
            if (updatefeedback == "") { MessageBox.Show("Nothing to Update"); }
            else if (updatefeedback == "Update completed") { MessageBox.Show("Update completed"); }
            else if (updatefeedback == "Update failed") { MessageBox.Show("Update filed"); }
        }
        /// <summary>
        /// Specify the employee and date, the function will return the shift list of the week about the employee.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="employee"></param>
        /// <returns></returns>
        private List<AssignedShift> GetEmployee_Assigned_Shift_For_The_Week(DateTime date, Employee employee)
        {
            List<AssignedShift> temp = new List<AssignedShift>();
            DateTime startdate=date;
            if (date.DayOfWeek.ToString() == "Monday") { startdate = date; }
            else if (date.DayOfWeek.ToString() == "Tuesday") { startdate = date.AddDays(-1); }
            else if (date.DayOfWeek.ToString() == "Wednesday") { startdate = date.AddDays(-2); }
            else if (date.DayOfWeek.ToString() == "Thursday") { startdate = date.AddDays(-3); }
            else if (date.DayOfWeek.ToString() == "Friday") { startdate = date.AddDays(-4); }
            else if (date.DayOfWeek.ToString() == "Saturday") { startdate = date.AddDays(-5); }
            else if (date.DayOfWeek.ToString() == "Sunday") { startdate = date.AddDays(-6); }         
            for (int i = 0; i < 7; i++)
            {   //Get the shift list for this week
                temp.AddRange(Get_Assigned_Shifts_By_Date(startdate.AddDays(i))); 
            }
            List<AssignedShift> employee_shift = new List<AssignedShift>();
            foreach (AssignedShift e in temp)
            {
                if (e.Employee.GetBSN() == employee.GetBSN())
                {
                    employee_shift.Add(e);
                }
            }
            return employee_shift;
        }
        /// <summary>
        /// Get Assined shift list by specify the date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private List<AssignedShift> Get_Assigned_Shifts_By_Date(DateTime date)
        {
            List<AssignedShift> temp = new List<AssignedShift>();
            foreach (AssignedShift e in allAssignedShifts)
            {
                if (e.Date.ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
                {
                    temp.Add(e);
                }
            }
            return temp;
        }
        public Availability GetAvailability(int bsn)
        {
            //Check Current List
            foreach (Availability x in allAvailableShifts)
            {
                if (x.employee.GetBSN() == bsn)
                {
                    return x;
                }
            }
            return null;
        }
 
        //private List<PreferenceShift> Get_Preference_Shifts_By_Date(DateTime date)
        //{
        //    List<PreferenceShift> temp = new List<PreferenceShift>();
        //    foreach (PreferenceShift e in allAvailableShifts)
        //    {
        //        if (e.GetDate().ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
        //        {
        //            temp.Add(e);
        //        }
        //    }
        //    return temp;
        //}
        public List<Availability> GetAvailabilities()
        {
            return allAvailableShifts;
        }
        public List<Availability> GetAvailabilitiesByDepartment(Departments department){
            throw new NotImplementedException();
        }

        public List<Availability> GetWorkerAvailabilitiesByDepartment (Departments department)
        {
            List<Availability> result = new List<Availability>();
            foreach(Availability availability in allAvailableShifts)
            {
                if(availability.employee.GetDepartment() == department && (availability.employee.GetPosition() == PositionType.Depot_Worker || availability.employee.GetPosition() == PositionType.Sales_Worker))
                {
                    result.Add(availability);
                }
            }
            return result;
        }

        public List<Availability> GetManagerAvailabilitiesByDepartment(Departments department)
        {
            List<Availability> result = new List<Availability>();
            foreach (Availability availability in allAvailableShifts)
            {
                if (availability.employee.GetDepartment() == department && (availability.employee.GetPosition() == PositionType.Depot_Manager || availability.employee.GetPosition() == PositionType.Sales_Manager))
                {
                    result.Add(availability);
                }
            }
            return result;
        }

        public void AssignNextWeekShifts(List<Employee>[] nextWeekEmployees)
        {
            //1. Determine next week
            DateTime tomorrow = DateTime.Today.AddDays(1);
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)tomorrow.DayOfWeek + 7) % 7;
            DateTime nextMonday = tomorrow.AddDays(daysUntilMonday);
            DateTime nextWeekFriday = nextMonday.AddDays(4);



            //2. Clear shifts
            DeleteAssignedShiftsFromNextWeek(nextMonday, nextWeekFriday);




            //3. List of unique employees we need to keep track of this week
            List<Employee> assignedEmployees = new List<Employee>();
            for(int i = 0; i < 15; i++)
            {
                foreach(Employee emp in nextWeekEmployees[i])
                {
                    if (!assignedEmployees.Contains(emp))
                        assignedEmployees.Add(emp);
                }
            }

            //4. Change to AssignedShift format
            List<AssignedShift> nextWeekShifts = new List<AssignedShift>();
            foreach(Employee emp in assignedEmployees)
            {
                for(int i = 0; i < 13; i += 3)
                {
                    ShiftType type;
                    if (nextWeekEmployees[i].Contains(emp) && (nextWeekEmployees[i + 1].Contains(emp)))
                        type = ShiftType.Morning_Afternoon;
                    else if (nextWeekEmployees[i].Contains(emp) && (nextWeekEmployees[i + 2].Contains(emp)))
                        type = ShiftType.Morning_Evening;
                    else if (nextWeekEmployees[i + 1].Contains(emp) && (nextWeekEmployees[i + 2].Contains(emp)))
                        type = ShiftType.Afternoon_Evening;
                    else if (nextWeekEmployees[i].Contains(emp))
                        type = ShiftType.Morning;
                    else if (nextWeekEmployees[i + 1].Contains(emp))
                        type = ShiftType.Afternoon;
                    else if (nextWeekEmployees[i + 2].Contains(emp))
                        type = ShiftType.Evening;
                    else
                        type = ShiftType.None;

                    if(type != ShiftType.None)
                    {
                        //i == 0 monday, i == 3 tuesday, i == 6 wednesday
                        DateTime assignmentDate = nextMonday.AddDays(i / 3);


                        nextWeekShifts.Add(new AssignedShift(emp, assignmentDate, type));
                    }
                }
            }

            //5. Update storage
            this.allAssignedShifts.AddRange(nextWeekShifts);

            //6. Update database
            schManagement.AssignNextWeekShifts(nextWeekShifts);

        }
        private void DeleteAssignedShiftsFromNextWeek(DateTime nextMonday, DateTime nextWeekFriday)
        {
            //Delete from storage
            for(int i = allAssignedShifts.Count - 1; i > -1; i--)
            {
                if(allAssignedShifts[i].Date >= nextMonday && allAssignedShifts[i].Date <= nextWeekFriday)
                {
                    allAssignedShifts.Remove(allAssignedShifts[i]);
                }
            }

            //Delete from database
            schManagement.DeleteNextWeekShifts(nextMonday, nextWeekFriday);
        }
    }
}