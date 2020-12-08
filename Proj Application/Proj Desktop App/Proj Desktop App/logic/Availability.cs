using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Availability : IComparable
    {
        private Employee emp;
        private ShiftType[] weekAvailability;
        public decimal leeway;

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
