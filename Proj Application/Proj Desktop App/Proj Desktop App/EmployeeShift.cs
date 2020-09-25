using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class EmployeeShift
    {
        Employee employee;
        public DateTime shiftDateTimeStart;
        public DateTime shiftDateTimeEnd;
        ShiftType shiftType;

        public EmployeeShift(Employee employee, DateTime shiftDateTimeStart, DateTime shiftDateTimeEnd, ShiftType shiftType)
        {
            this.employee = employee;
            this.shiftDateTimeStart = shiftDateTimeStart;
            this.shiftDateTimeEnd = shiftDateTimeEnd;
            this.shiftType = shiftType;
        }


    }
}
