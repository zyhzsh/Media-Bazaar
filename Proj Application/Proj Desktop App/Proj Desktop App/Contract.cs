using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Contract
    {
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int Iteration { get; private set; }
        public Departments Department { get; private set; }
        public PositionType Position { get; private set; }
        public decimal Salary { get; private set; }
        public decimal Fte { get; private set; }

        public Contract(DateTime startDate, DateTime endDate, int iteration, Departments department,
                                PositionType position, decimal salary, decimal fte)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Iteration = iteration;
            this.Department = department;
            this.Position = position;
            this.Salary = salary;
            this.Fte = fte;
        }

        public bool Terminate(DateTime date)
        {
            if (IsActive() && date < EndDate && date >= DateTime.Now)
            {
                // End the contract
                EndDate = date;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Promote(decimal percent)
        {
            if (IsActive())
            {
                // Increse the salary
                Salary += Salary * percent;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsActive()
        {
            if (DateTime.Now >= StartDate && DateTime.Now <= EndDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsCloseToEndDate()
        {
            if (DateTime.Now.AddMonths(1) >= EndDate)
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
            string endDateStr = "N/A";
            if (EndDate != null)
            {
                endDateStr = EndDate.ToString("dd/MM/yyyy");
            }

            string status;
            if (EndDate < DateTime.Now)
            {
                status = "ended";
            }
            else if (StartDate > DateTime.Now)
            {
                status = "not started";
            }
            else
            {
                status = "active";
            }


            return $"{StartDate:dd/MM/yyyy},{endDateStr},{Position},{Department},{Fte},€{Salary},{status}";
        }
    }
}
