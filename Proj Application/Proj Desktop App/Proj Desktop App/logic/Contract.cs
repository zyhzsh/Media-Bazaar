using Proj_Desktop_App.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int Iteration { get; private set; }
        public Department Department { get; private set; }
        public PositionType Position { get; private set; }
        public decimal Salary { get; private set; }
        public decimal Fte { get; private set; }

        public Contract(int id, DateTime startDate, DateTime endDate, int iteration, Department department,
                                PositionType position, decimal salary, decimal fte)
        {
            this.Id = id;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Iteration = iteration;
            this.Department = department;
            this.Position = position;
            this.Salary = salary;
            this.Fte = fte;
        }

        /// <summary>
        /// Changes the end date of a contract and updates DB
        /// </summary>
        public void Terminate(DateTime date)
        {
            if (IsActive() && date < EndDate && date >= DateTime.Today)
            {
                ContractManagement contrMan = new ContractManagement();
                if (contrMan.TerminateContract(this.Id, date))
                {
                    // End the contract
                    EndDate = date;
                }
                else
                {
                    throw new Exception("Failed to terminate contract. Check database connection.");
                }
            }
            else
            {
                throw new Exception("You can only terminate an active contract.");
            }
        }

        /// <summary>
        /// Upadetes the salary in a contrat and updates DB
        /// </summary>
        /// <param name="percent"></param>
        public void Promote(decimal percent)
        {
            if (IsActive())
            {
                decimal newSalary = Salary + (Salary * percent / 100);
                ContractManagement contrMan = new ContractManagement();
                if (contrMan.Promote(this.Id, newSalary))
                {
                    // Increse the salary
                    Salary = newSalary;
                }
                else
                {
                    throw new Exception("Failed to update contract. Check Database connection.");
                }
            }
            else
            {
                throw new Exception("This contract is not active.");
            }
        }

        public bool IsActive()
        {
            if (DateTime.Today >= StartDate && DateTime.Today <= EndDate)
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
            if (IsActive() && DateTime.Today.AddMonths(1) >= EndDate)
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

            string status = "";
            if (IsCloseToEndDate()) 
                { status = "ending"; }
            else if (IsActive())
                { status = "active"; }
            else if (EndDate < DateTime.Today)
                { status = "ended";}
            else if (StartDate > DateTime.Today)
                { status = "not started"; }


            return $"{StartDate:dd/MM/yyyy},{endDateStr},{Position},{Department},{Fte},€{Salary},{status}";
        }
    }
}
