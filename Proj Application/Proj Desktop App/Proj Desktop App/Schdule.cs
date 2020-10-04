using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class Schedule
    {
        //draft class right now
        //we either safe everything in this class and display any date that is asked for
        //or this class gets filled for the date and there is another entity (class/db) that has everything in it and sorts it per date
        //currently this is the collection class with all the info

        private static  List<AssignedShift> assignedShifts;
        private static List<AvailableShifts> availableShifts; //not in use as of yet

        public Schedule(List<AssignedShift> AssignedShifts)
        {
            assignedShifts = AssignedShifts;
        }
        public Schedule(string test)
        {
            //mock data still needs to be done
        }


        public Schedule()
        {    
        }

        public List<AssignedShift> GetAssignedShifts()
        {
            return assignedShifts;
        }
        public List<AvailableShifts> GetAvailableShifts()
        {
            return availableShifts;
        }



        /// <summary>
        ///Specify the day
        ///This function will set some special rules then 
        ///Load period of data from databas
        /// </summary>
        public void LoadSchduleFormDateBase(DateTime dateTime)
        {
            //Specify the day
            //This function will set some special rules then 
            //Load period of data Form databas
            
            //But For now ...
            assignedShifts = new List<AssignedShift>();
        }



        public void UpDateSchdule(List<AssignedShift> UpdatedShifts)
        {
            assignedShifts = UpdatedShifts;
            //1.Compare different
            //2.Send to database
            SaveSchduleToDateBase();
        }


        private void SaveSchduleToDateBase()
        { 
            //Write Shift info to database

            //for now ...
        }


        /* this part is taken over by schedule manager
        

        public List<AssignedShift> GetDateShifts(DateTime date)
        {
            List<AssignedShift> shifts = new List<AssignedShift>();

            foreach(AssignedShift shift in assignedShifts)
            {
                if(shift.shiftDateTimeStart.Date == date.Date)
                {
                    shifts.Add(shift);
                }
            }

            return shifts;
        }

        public List<AssignedShift> GetDateShifts(DateTime startDate, DateTime endDate)
        {
            List<AssignedShift> shifts = new List<AssignedShift>();
            List<DateTime> dates = new List<DateTime>();

            for (DateTime sd = startDate.Date; sd.Date <= endDate.Date; sd = sd.AddDays(1))
            {
                dates.Add(sd);
            }

            foreach (AssignedShift shift in assignedShifts)
            {
                foreach(DateTime date in dates)
                {
                    if (shift.shiftDateTimeStart.Date == date.Date)
                    {
                        shifts.Add(shift);
                    }
                }
            }

            return shifts;
        }
        */


        //no check on preffered shifts yet
        //would take  this from available shifts to assigned shifts later. if we implement that way of functioning with the schedule
        public AssignedShift AddShift(Employee employee, DateTime shiftDateTimeStart, ShiftType shiftType)
        {
            AssignedShift assignedShift = new AssignedShift(employee, shiftDateTimeStart, shiftType);
            assignedShifts.Add(assignedShift);
            return assignedShift;
        }

        public AssignedShift RemoveShift(AssignedShift removeShift)
        {
            assignedShifts.Remove(removeShift);
            return removeShift;

        }

        public AssignedShift RemoveShift(Employee employee, DateTime shiftDateTimeStart, ShiftType shiftType)
        {
            AssignedShift removeShift = new AssignedShift(employee, shiftDateTimeStart, shiftType);
            assignedShifts.Remove(removeShift);
            return removeShift;
        }

        //not adapted to schedule manager yet
        public void UpdateShift(AssignedShift changeShift, Employee employee, DateTime shiftDateTimeStart, DateTime shiftDateTimeEnd, ShiftType shiftType)
        {
            AssignedShift changedShift = new AssignedShift(employee, shiftDateTimeStart, shiftType);

            foreach (AssignedShift shift in assignedShifts)
            {
                if (shift == changeShift)
                {
                    assignedShifts.Remove(shift);
                    assignedShifts.Add(changedShift);
                }
            }
        }

        //obsolete with the schedule manager? everything under this
        public AssignedShift GetShift(Employee employee, DateTime shiftDateTimeStart, ShiftType shiftType)
        {
            string emptyShift = "null";
            AssignedShift getShift = new AssignedShift(employee, shiftDateTimeStart, shiftType);
            AssignedShift nullShift = new AssignedShift(emptyShift);

            foreach (AssignedShift shift in assignedShifts)
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

            foreach (AssignedShift shift in assignedShifts)
            {
                if (shift == getShift)
                {
                    return shift;
                }
            }

            return nullShift;
        }
    }
}
