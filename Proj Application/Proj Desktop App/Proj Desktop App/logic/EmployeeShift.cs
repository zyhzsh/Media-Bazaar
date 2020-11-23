﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public abstract class EmployeeShift
    {
        protected Employee employee;
        protected DateTime date;
        protected ShiftType shiftType;
        public EmployeeShift(Employee employee, DateTime date, ShiftType shiftType)
        {
            this.employee = employee;
            this.date = date;
            this.shiftType = shiftType;
        }
        public Employee GetEmployee() {return this.employee;}
        public DateTime GetDate() { return this.date; }
        public ShiftType GetShiftType() { return this.shiftType; }
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
            }
            return "";
        }
    }

}