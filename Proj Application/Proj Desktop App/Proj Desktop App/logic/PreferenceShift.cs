﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class PreferenceShift : EmployeeShift
    {
        public PreferenceShift(Employee employee, DateTime date, ShiftType shiftType) : base(employee, date, shiftType) { }
    }
}