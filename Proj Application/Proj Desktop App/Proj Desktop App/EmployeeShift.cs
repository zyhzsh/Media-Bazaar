<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
   abstract class EmployeeShift
    {
        protected Employee employee;
        protected DateTime date;
        protected ShiftType shiftType;
        abstract public Employee GetEmployee();
        abstract public DateTime GetDate();
        abstract public ShiftType GetShiftType();
    }
    
}
=======
﻿using System;
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
>>>>>>> parent of 83ec41c... ScheduleManager implemented
