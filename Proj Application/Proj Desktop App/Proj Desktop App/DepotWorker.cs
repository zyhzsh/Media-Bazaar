using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class DepotWorker:Employee
    {
        private string job;
        public DepotWorker(int BSN, string firstName, string LastName, string gender, int phoneNumber, DateTime birthDate,
                          string adress, string certificates, string status, string department, string contactEmail, double fte, string job)
              : base(BSN, firstName, LastName, gender, phoneNumber, birthDate, adress, certificates, status, department, contactEmail, fte)
        {
            this.job = job;
        }
    }
}
