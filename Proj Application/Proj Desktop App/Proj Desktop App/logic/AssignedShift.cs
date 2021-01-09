using System;

namespace Proj_Desktop_App
{
    public class AssignedShift : EmployeeShift
    {
        public AssignedShift(Employee employee, DateTime date, ShiftType shiftType) : base(employee, date, shiftType) { }
        public void UpDateShiftType(ShiftType shiftType) { this.shiftType = shiftType; }
    }
}
