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

    }
}
