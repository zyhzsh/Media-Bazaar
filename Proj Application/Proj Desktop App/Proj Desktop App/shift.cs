using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    abstract class Shift
    {
        public string SelectedDate { get; set; }
        public ShiftType ShiftType { get; set; }

        protected Shift(string SelectedDate, ShiftType ShiftType)
        {
            this.SelectedDate = SelectedDate;
            this.ShiftType = ShiftType;
        }



        public abstract List<Employee> GetShiftsList();
    }
}
