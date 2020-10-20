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