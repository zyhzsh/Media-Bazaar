using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Proj_Desktop_App.dataAccess;

namespace Proj_Desktop_App
{
    class ScheduleManager
    {
        private List<AssignedShift> allAssignedShifts;
        private List<PreferenceShift> allAvailableShifts;
        private EmployeeStorage store;
        private List<string> sqlstatements;
        public ScheduleManager(EmployeeStorage store)
        {
            this.store = store;
            ScheduleManagement x = new ScheduleManagement();
            x.LoadSchduleFormDateBase(DateTime.Now);
            this.allAssignedShifts = x.GetAssignedShifts();
            this.allAvailableShifts = x.GetAvailableShifts();
            sqlstatements = new List<string>();
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
                if (e.GetDate().ToString("yyyy-MM-dd") == time.ToString("yyyy-MM-dd") &&e.GetEmployee().GetDepartment()== departments)
                {
                    temp.Add($"{e.GetEmployee().ToString()} Shift:{e.GetShiftTypeToString()} {e.GetDate().ToString("dddd, dd MMMM")}");
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
           sqlstatements.Clear();
           try
            {
                ReLoadSchdule(date); 
                foreach (int i in bsns)
                {
                    if (!AssignShift(date, i, shiftType))
                    {
                        string temp = "It's over " + store.GetEmployee(i).ToString() + "'s FTE";                       
                        MessageBox.Show(temp);
                    }
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            UpDateAssignedShiftToSchdule(sqlstatements);
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
            Employee employee = store.GetEmployee(bsn);
            //2.Get employee's Assigned shift list for the week
            List<AssignedShift> current_week_shift_list_for_the_employee = GetEmployee_Assigned_Shift_For_The_Week(date, employee);           
            bool havetheshift = false;
            //3.if have the shift
            foreach (AssignedShift e in current_week_shift_list_for_the_employee)
            {
                //if (e.GetDate().ToString("dd/MM/yyyy") == date.ToString("dd/MM/yyyy"))
                if (e.GetDate().ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
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
                switch (assigned.GetShiftType())
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
                    //if (e.GetDate().ToString("dd/MM/yyyy") == date.ToString("dd/MM/yyyy"))
                    if (e.GetDate().ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
                    {
                        if (e.GetEmployee().GetBSN() == employee.GetBSN())
                        {
                            e.UpDateShiftType(shiftType);
                            sqlstatements.Add($"UPDATE `assignedschdule` SET `assigned_shift_type`= '{shiftType.ToString()}' WHERE BSN ='{employee.GetBSN()}' AND date='{date.ToString("yyyy-MM-dd")}';");
                            haverecords = true;
                            return true;
                        }
                    }
                }
                if (haverecords == false)
                {
                    AssignedShift x = new AssignedShift(employee, date, shiftType);
                    allAssignedShifts.Add(x);
                    sqlstatements.Add($"INSERT INTO `assignedschdule` (`BSN`, `date`, `assigned_shift_type`) VALUES('{employee.GetBSN()}', '{date.ToString("yyyy-MM-dd")}', '{shiftType}');");
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
            sqlstatements.Clear();
            try
            {
                List<Employee> emp = new List<Employee>();
                foreach (int i in bsns)
                {
                    emp.Add(store.GetEmployee(i));
                }
                List<AssignedShift> temp = new List<AssignedShift>();
                foreach (AssignedShift e in allAssignedShifts)
                {
                    if (e.GetDate().ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
                    {
                        temp.Add(e);
                    }
                }
                foreach (Employee e in emp)
                {
                    foreach (AssignedShift b in temp)
                    {
                        if (b.GetEmployee().GetBSN() == e.GetBSN())
                        {
                            allAssignedShifts.Remove(b);                    
                            sqlstatements.Add($"DELETE FROM `assignedschdule` WHERE date='{date.ToString("yyyy-MM-dd")}' AND BSN='{e.GetBSN()}';");
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
            UpDateAssignedShiftToSchdule(sqlstatements);
            return true;
        }
        /// <summary>
        /// Update Current list of Shift information form Schdule Class
        /// </summary>
        /// <param name="date"></param>
        private void ReLoadSchdule(DateTime date)
        {
            ScheduleManagement a = new ScheduleManagement();
            a.LoadSchduleFormDateBase(date);
            allAssignedShifts = a.GetAssignedShifts();
            allAvailableShifts=a.GetAvailableShifts();
        }
        /// <summary>
        /// Update the shift changes to the Schdule Class 
        /// </summary>
        private void UpDateAssignedShiftToSchdule(List<string> sqls)
        {
            ScheduleManagement a = new ScheduleManagement();         
            a.UpDateSchdule(allAssignedShifts,sqls);
        }
        /// <summary>
        /// Specify the employee and date, the function will return the shift list of the week about the employee.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="employee"></param>
        /// <returns></returns>
        public List<AssignedShift> GetEmployee_Assigned_Shift_For_The_Week(DateTime date, Employee employee)
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
                if (e.GetEmployee().GetBSN() == employee.GetBSN())
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
        public List<PreferenceShift> GetEmployee_Preference_Shift_For_The_Week(Employee employee,DateTime date)
        {
            List<PreferenceShift> temp = new List<PreferenceShift>();
            //Check Current List
            DateTime startdate = date;
            if (date.DayOfWeek.ToString() == "Monday") { startdate = date; }
            else if (date.DayOfWeek.ToString() == "Tuesday") { startdate = date.AddDays(-1); }
            else if (date.DayOfWeek.ToString() == "Wednesday") { startdate = date.AddDays(-2); }
            else if (date.DayOfWeek.ToString() == "Thursday") { startdate = date.AddDays(-3); }
            else if (date.DayOfWeek.ToString() == "Friday") { startdate = date.AddDays(-4); }
            else if (date.DayOfWeek.ToString() == "Saturday") { startdate = date.AddDays(-5); }
            else if (date.DayOfWeek.ToString() == "Sunday") { startdate = date.AddDays(-6); }
            for (int i = 0; i < 7; i++)
            {   //Get the shift list for this week
                temp.AddRange(Get_Preference_Shifts_By_Date(startdate.AddDays(i)));
            }
            List<PreferenceShift> employee_shift = new List<PreferenceShift>();
            foreach (PreferenceShift e in temp)
            {
                if (e.GetEmployee().GetBSN() == employee.GetBSN())
                {
                    employee_shift.Add(e);
                }
            }
            return employee_shift;
        }
        private List<AssignedShift> Get_Assigned_Shifts_By_Date(DateTime date)
        {
            List<AssignedShift> temp = new List<AssignedShift>();
            foreach (AssignedShift e in allAssignedShifts)
            {
                if (e.GetDate().ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
                {
                    temp.Add(e);
                }
            }
            return temp;
        }
        private List<PreferenceShift> Get_Preference_Shifts_By_Date(DateTime date)
        {
            List<PreferenceShift> temp = new List<PreferenceShift>();
            foreach (PreferenceShift e in allAvailableShifts)
            {
                if (e.GetDate().ToString("yyyy-MM-dd") == date.ToString("yyyy-MM-dd"))
                {
                    temp.Add(e);
                }
            }
            return temp;
        }
    }
}