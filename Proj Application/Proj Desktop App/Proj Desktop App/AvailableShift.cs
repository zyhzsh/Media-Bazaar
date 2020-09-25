using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class AvailableShift : EmployeeShift
    {
        //enum for why not available or preffered is an option to distinguis the info. could also just use a string ofc
        public AvailableShift(Employee employee, DateTime shiftDateTimeStart, DateTime shiftDateTimeEnd, ShiftType shiftType) : base(employee, shiftDateTimeStart, shiftDateTimeEnd, shiftType)
        {

        }
    }
}
