using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class AssignedShift : EmployeeShift
    {

        public AssignedShift(Employee employee, DateTime date, ShiftType shiftType)
        {
            this.employee = employee;
            this.date = date;
            this.shiftType = shiftType;
        }
        public override Employee GetEmployee() { return this.employee; }
        public override DateTime GetDate() { return this.date; }
        public override ShiftType GetShiftType() { return this.shiftType; }
        public void UpDateShift(ShiftType shiftType) { this.shiftType = shiftType; }

        public string GetShiftTypeToString()
        {
            switch (shiftType)
            {
                case ShiftType.Evening: return "Evening";
                case ShiftType.Morning: return "Monring";
                case ShiftType.Afternoon: return "Afternoon";
                case ShiftType.Morning_Afternoon: return "Monrning,Afternoon";
                case ShiftType.Morning_Evening: return "Monring,Evening";
                case ShiftType.Afternoon_Evening: return "Afternoon,Evening";
                case ShiftType.FullDay: return "FullDay";
            }
            return "";
        }




        //null shift
        public AssignedShift(string nullShift)
        {

        }

    }
}
