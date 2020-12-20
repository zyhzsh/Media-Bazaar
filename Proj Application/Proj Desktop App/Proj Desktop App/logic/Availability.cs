using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Availability : IComparable<Availability>
    {
        public Employee Employee { get; private set; }
        public ShiftType[] WeekAvailability { get; private set; }
        public decimal Leeway { get; set; } 
        public Availability(Employee employee,ShiftType[] shiftTypes)
        {
            Employee = employee;
            WeekAvailability = shiftTypes;
            Leeway = CalculateLeeWay();
        }
        public decimal CalculateLeeWay()
        {
            decimal leewaycounter = 0;
            foreach (ShiftType type in WeekAvailability)
            {
                switch (type)
                {
                    case ShiftType.Morning:
                    case ShiftType.Afternoon:
                    case ShiftType.Evening:
                        leewaycounter += 1;
                        break;
                    case ShiftType.Morning_Afternoon:
                    case ShiftType.Morning_Evening:
                    case ShiftType.Afternoon_Evening:
                        leewaycounter += 2;
                        break;
                    case ShiftType.FullDay:
                        leewaycounter += 3;
                        break;
                    case ShiftType.None:
                              break;
                }
            }
            leewaycounter = leewaycounter-Employee.GetFTE() * 10;
            return leewaycounter;
        }
        public int CompareTo(Availability other)
        {
            return Leeway.CompareTo(other.Leeway);
        }
        public string test()
        {
            return $"{Employee.GetFTE()} leeway:{Leeway}";
        }

    }
}
