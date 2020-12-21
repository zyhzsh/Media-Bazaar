﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Availability : IComparable
    {
        public decimal leeway;

        /// <summary>
        /// 5 length array of the employee's shifts for each working day
        /// </summary>
        public ShiftType[] WeekAvailability { get; private set; }

        public Employee employee { get; private set; }
        public Availability(Employee employee, ShiftType[] WeekAvailability)
        {
            this.employee = employee;
            this.WeekAvailability = WeekAvailability;
            this.leeway = CountAvailableShifts() - this.employee.GetFTE() * 10;
        }

        private int CountAvailableShifts()
        {
            int availableShiftCounter = 0;
            foreach (ShiftType shift in WeekAvailability)
            {
                availableShiftCounter += ShiftTypeToInt(shift);
            }
            return availableShiftCounter;
        }

        public static int ShiftTypeToInt(ShiftType shift)
        {
            if (shift == ShiftType.Afternoon_Evening || shift == ShiftType.Morning_Afternoon || shift == ShiftType.Morning_Evening)
            {
                return 2;
            }
            else if (shift == ShiftType.FullDay)
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
        public int CompareTo(object obj)
        {
            if(obj != null)
            {
                Availability otherAvailability = obj as Availability;
                if(otherAvailability != null)
                {
                    if (otherAvailability.leeway > this.leeway) return 1;
                    else if (otherAvailability.leeway < this.leeway) return -1;
                    else return 0;
                }
            }
            return 1;
        }
    }
}
