using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Contract
    {
        private DateTime startDate;
        private DateTime endDate;
        public int Iteration { get; private set; }
        public Departments Department { get; private set; }
        public PositionType Position { get; private set; }
        private decimal salary;
        public decimal Fte { get; private set; }

        public Contract(DateTime startDate, DateTime endDate, int iteration, Departments department,
                                PositionType position, decimal salary, decimal fte)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.Iteration = iteration;
            this.Department = department;
            this.Position = position;
            this.salary = salary;
            this.Fte = fte;
        }

        public bool IsActive()
        {
            if (DateTime.Now >= startDate && DateTime.Now <= endDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string endDate = "none";
            if (endDate != null)
            {
                endDate = this.endDate.ToString("dd/MM/yyyy");
            }
            string isActive = "not active";
            if (IsActive()) { isActive = "active"; }


            return $"{startDate:dd/MM/yyyy},{endDate},{Position},{Department},{Fte},€{salary},{isActive}";
        }
    }
}
