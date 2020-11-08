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
        private int iteration;
        public Departments Department { get; private set; }
        public PositionType Position { get; private set; }
        private decimal salary;
        public decimal Fte { get; private set; }
        private bool active;

        public Contract(DateTime startDate, DateTime endDate, int iteration, Departments department,
                                PositionType position, decimal salary, decimal fte, bool active)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.iteration = iteration;
            this.Department = department;
            this.Position = position;
            this.salary = salary;
            this.Fte = fte;
            this.active = active;
        }
    }
}
