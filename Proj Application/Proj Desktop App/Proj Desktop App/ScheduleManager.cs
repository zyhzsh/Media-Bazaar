using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    class ScheduleManager
    {
        //all the shifts ever assigned will be recorded here. This will change when a database is connected
        List<AssignedShift> allAssignedShifts;
        //This contains all available shifts to be filled. Might be used for a standard roster later
        List<AvailableShift> allAvailableShifts;
        List<Employee> employees;
        Store store;
        
        public ScheduleManager(List<AssignedShift> allAssignedShifts)
        {
            this.allAssignedShifts = allAssignedShifts;
        }

        public ScheduleManager(List<AssignedShift> allAssignedShifts, List<AvailableShift> allAvailableShifts)
        {
            this.allAssignedShifts = allAssignedShifts;
            this.allAvailableShifts = allAvailableShifts;
        }

        public ScheduleManager(Store store)
        {
            this.store = store;
            this.allAssignedShifts = new List<AssignedShift>();
            this.allAvailableShifts = new List<AvailableShift>();
        }

        //Test Date
        public void AddTestDate()
        {
            this.allAssignedShifts = new List<AssignedShift>();

        }


        //fill schedule for 1 date
        public Schedule GetDateShifts(DateTime date)
        {
            Schedule schedule = new Schedule();

            foreach (AssignedShift shift in allAssignedShifts)
            {
                if (shift.GetDate().Date == date.Date)
                {
                    schedule.GetAssignedShifts().Add(shift);
                }
            }

            return schedule;
        }

        //fill schedule for a range of dates
        public Schedule GetDateShifts(DateTime startDate, DateTime endDate)
        {
            Schedule schedule = new Schedule();
            List<DateTime> dates = new List<DateTime>();

            for (DateTime sd = startDate.Date; sd.Date <= endDate.Date; sd = sd.AddDays(1))
            {
                dates.Add(sd);
            }

            foreach (AssignedShift shift in allAssignedShifts)
            {
                foreach (DateTime date in dates)
                {
                    if (shift.GetDate().Date == date.Date)
                    {
                        schedule.GetAssignedShifts().Add(shift);
                    }
                }
            }

            return schedule;
        }

        public void AddShift(Schedule schedule, Employee employee, DateTime shiftDateTime, ShiftType shiftType)
        {
            allAssignedShifts.Add(schedule.AddShift(employee, shiftDateTime, shiftType));
        }

        public void RemoveShift(Schedule schedule, Employee employee, DateTime shiftDateTime, ShiftType shiftType)
        {
            allAssignedShifts.Remove(schedule.AddShift(employee, shiftDateTime, shiftType));
        }


        public AssignedShift GetShift(Employee employee, DateTime shiftDateTimeStart, ShiftType shiftType)
        {
            string emptyShift = "null";
            AssignedShift getShift = new AssignedShift(employee, shiftDateTimeStart, shiftType);
            AssignedShift nullShift = new AssignedShift(emptyShift);

            foreach (AssignedShift shift in allAssignedShifts)
            {
                if (shift == getShift)
                {
                    return shift;
                }
            }

            return nullShift;
        }

        public AssignedShift GetShift(AssignedShift getShift)
        {
            string emptyShift = "null";
            AssignedShift nullShift = new AssignedShift(emptyShift);

            foreach (AssignedShift shift in allAssignedShifts)
            {
                if (shift == getShift)
                {
                    return shift;
                }
            }

            return nullShift;
        }

        /// <summary>
        /// Specify the day then return list of employee's information
        /// </summary>
        /// <param name="time"> DateTime</param>
        /// <returns></returns>
        public string[] GetEmployeesInfoByDate(DateTime time)
        {
            List<string> temp = new List<string>();
            foreach (AssignedShift e in allAssignedShifts)
            {
                if (e.GetDate().ToString("dd/MM/yyyy") == time.ToString("dd/MM/yyyy"))
                {
                    temp.Add($"{e.GetEmployee().GetBsnAndName()} Shift:{e.GetShiftTypeToString()} {e.GetDate().ToString("dddd, dd MMMM")}");
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
                //ReLoadSchdule(date); 
                List<AssignedShift> temp = new List<AssignedShift>();
                foreach (AssignedShift e in allAssignedShifts)
                {
                    if (e.GetDate().ToString("dd/MM/yyyy") == date.ToString("dd/MM/yyyy"))
                    {
                        temp.Add(e);
                    }
                }
                foreach (int i in bsns)
                {
                    bool haverecords = false;
                    while (haverecords == false)
                    {
                        foreach (AssignedShift e in temp)
                        {
                            if (e.GetEmployee().GetBSN() == i)
                            {
                                e.UpDateShift(shiftType);
                                haverecords = true;
                                break;
                            }
                        }
                        if (haverecords == false)
                        {
                            AssignedShift newShift = new AssignedShift(store.GetEmployee(i), date, shiftType);
                            allAssignedShifts.Add(newShift);
                            haverecords = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            //UpDateAssignedShiftToSchdule();
            return true;
        }

        public bool RemoveShift(DateTime date, List<int> bsns)
        {
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
                    if (e.GetDate().ToString("dd/MM/yyyy") == date.ToString("dd/MM/yyyy"))
                    {
                        temp.Add(e);
                    }
                }
                foreach (Employee e in emp)
                {
                    foreach (AssignedShift b in temp)
                    {
                        if (b.GetEmployee() == e)
                        {
                            allAssignedShifts.Remove(b);
                            break;
                        }
                    }
                }
                //UpDateAssignedShiftToSchdule();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }


        /// <summary>
        /// Update Current list of Shift information form Schdule Class
        /// </summary>
        /// <param name="date"></param>
        private void ReLoadSchdule(DateTime date)
        {
            Schedule a = new Schedule();
            a.LoadSchduleFormDateBase(date);
            allAssignedShifts = a.GetAssignedShifts();
            //allAvailableShifts=a.GetAvailableShifts();
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpDateAssignedShiftToSchdule()
        {
            Schedule a = new Schedule();
            a.UpDateSchdule(allAssignedShifts);
        }





    }
}