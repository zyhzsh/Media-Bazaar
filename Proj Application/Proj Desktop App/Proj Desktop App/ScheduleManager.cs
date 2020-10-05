using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Proj_Desktop_App
{
    class ScheduleManager
    {
        //all the shifts ever assigned will be recorded here. This will change when a database is connected
        List<AssignedShift> allAssignedShifts;

        //This contains all available shifts to be filled. Might be used for a standard roster later
        List<AvailableShifts> allAvailableShifts;

        public ScheduleManager(List <AssignedShift> allAssignedShifts)
        {
            this.allAssignedShifts = allAssignedShifts;
        }

        public ScheduleManager(List<AssignedShift> allAssignedShifts, List<AvailableShifts> allAvailableShifts)
        {
            this.allAssignedShifts = allAssignedShifts;
            this.allAvailableShifts = allAvailableShifts;                
        }

        public ScheduleManager()
        {
            this.allAssignedShifts = new List<AssignedShift>();
            this.allAvailableShifts = new List<AvailableShifts>();
        }

        //fill schedule for 1 date
        public Schedule GetDateShifts(DateTime date)
        {
            Schedule schedule = new Schedule();

            foreach (AssignedShift shift in allAssignedShifts)
            {
                if (shift.shiftDateTime.Date == date.Date)
                {
                    schedule.assignedShifts.Add(shift);
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
                    if (shift.shiftDateTime.Date == date.Date)
                    {
                        schedule.assignedShifts.Add(shift);
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

    }
}
