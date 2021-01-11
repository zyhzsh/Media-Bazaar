using System;

namespace Proj_Desktop_App
{
    public class AssignedShift
    {
        public Employee Employee { get; private set; }
        public DateTime Date{ get; private set; }
        public ShiftType ShiftType { get; private set; }
        public AssignedShift(Employee employee, DateTime date, ShiftType shiftType)  {

            Employee = employee;
            Date = date;
            ShiftType = shiftType;
        }
        public string GetShiftTypeToString()
        {
            switch (ShiftType)
            {
                case ShiftType.Evening: return "Evening";
                case ShiftType.Morning: return "Monring";
                case ShiftType.Afternoon: return "Afternoon";
                case ShiftType.Morning_Afternoon: return "Monrning,Afternoon";
                case ShiftType.Morning_Evening: return "Monring,Evening";
                case ShiftType.Afternoon_Evening: return "Afternoon,Evening";
                case ShiftType.FullDay:return "FullDay";
            }
            return "";
        }
        public void UpDateShiftType(ShiftType shiftType) { ShiftType= shiftType; }
    }
}
