using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
   public class AssignedShift : EmployeeShift
    {
        public AssignedShift(Employee employee, DateTime date, ShiftType shiftType) : base(employee, date, shiftType) { }
        public void UpDateShiftType(ShiftType shiftType) { this.shiftType = shiftType; }
    }
}
