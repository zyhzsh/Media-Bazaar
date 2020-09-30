//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Proj_Desktop_App
//{
//    class Schedule
//    {
//        //draft class right now
//        //we either safe everything in this class and display any date that is asked for
//        //or this class gets filled for the date and there is another entity (class/db) that has everything in it and sorts it per date
//        //currently this is the collection class with all the info

//        List<AssignedShift> assignedShifts;

//        public Schedule( List<AssignedShift> assignedShifts)
//        {
//            this.assignedShifts = assignedShifts;
//        }

//        public Schedule()
//        {
//            assignedShifts = new List<AssignedShift>();
//        }

//        public Schedule(string test)
//        {
//            assignedShifts = new AssignedShift[1]; //mock data still needs to be done
//        }

//        public List<AssignedShift> GetDateShifts(DateTime date)
//        {
//            List<AssignedShift> shifts = new List<AssignedShift>();

//            foreach(AssignedShift shift in assignedShifts)
//            {
//                if(shift.shiftDateTimeStart.Date == date.Date)
//                {
//                    shifts.Add(shift);
//                }
//            }

//            return shifts;
//        }

//        public List<AssignedShift> GetDateShifts(DateTime startDate, DateTime endDate)
//        {
//            List<AssignedShift> shifts = new List<AssignedShift>();
//            List<DateTime> dates = new List<DateTime>();

//            for (DateTime sd = startDate.Date; sd.Date <= endDate.Date; sd = sd.AddDays(1))
//            {
//                dates.Add(sd);
//            }

//            foreach (AssignedShift shift in assignedShifts)
//            {
//                foreach(DateTime date in dates)
//                {
//                    if (shift.shiftDateTimeStart.Date == date.Date)
//                    {
//                        shifts.Add(shift);
//                    }
//                }
//            }

//            return shifts;
//        }

//        //no check on preffered shifts yet
//        public void AddShift(Employee employee, DateTime shiftDateTimeStart, DateTime shiftDateTimeEnd, ShiftType shiftType)
//        {
//            AssignedShift assignedShift = new AssignedShift(employee, shiftDateTimeStart, shiftDateTimeEnd, shiftType);
//            assignedShifts.Add(assignedShift);
//        }

//        public void RemoveShift(AssignedShift removeShift)
//        {
//            assignedShifts.Remove(removeShift);
//        }

//        public void RemoveShift(Employee employee, DateTime shiftDateTimeStart, DateTime shiftDateTimeEnd, ShiftType shiftType)
//        {
//            AssignedShift removeShift = new AssignedShift(employee, shiftDateTimeStart, shiftDateTimeEnd, shiftType);
//            assignedShifts.Remove(removeShift);
//        }

//        public void UpdateShift(AssignedShift changeShift, Employee employee, DateTime shiftDateTimeStart, DateTime shiftDateTimeEnd, ShiftType shiftType)
//        {
//            AssignedShift changedShift = new AssignedShift(employee, shiftDateTimeStart, shiftDateTimeEnd, shiftType);

//            foreach(AssignedShift shift in assignedShifts)
//            {
//                if(shift == changeShift)
//                {
//                    assignedShifts.Remove(shift);
//                    assignedShifts.Add(changedShift);
//                }
//            }
//        }

//        //it is currently not possible to make a empty shift. not a bad thing perse but we need a way to indicate get didnt work
//        //we just need to make a decision on this and be consistent in it during the project
//        public AssignedShift GetShift(Employee employee, DateTime shiftDateTimeStart, DateTime shiftDateTimeEnd, ShiftType shiftType)
//        {
//            AssignedShift getShift = new AssignedShift(employee, shiftDateTimeStart, shiftDateTimeEnd, shiftType);
//            AssignedShift nullShift = new AssignedShift();

//            foreach (AssignedShift shift in assignedShifts)
//            {
//                if (shift == getShift)
//                {
//                    return shift;
//                }
//            }

//            return nullShift;
//        }

//        public AssignedShift GetShift(AssignedShift getShift)
//        {
//            AssignedShift nullShift = new AssignedShift();

//            foreach (AssignedShift shift in assignedShifts)
//            {
//                if (shift == getShift)
//                {
//                    return shift;
//                }
//            }

//            return nullShift;
//        }
//    }
//}
