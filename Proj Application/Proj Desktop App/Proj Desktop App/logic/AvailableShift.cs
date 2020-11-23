using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class Preferenceshift : EmployeeShift
    {
        public Preferenceshift(Employee employee, DateTime date, ShiftType shiftType) : base(employee, date, shiftType) { }
    }
}
