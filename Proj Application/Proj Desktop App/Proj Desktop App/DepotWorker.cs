using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class DepotWorker:Employee
    {
        private string job="DepotWorker";
        public DepotWorker(int BSN, string firstName, string LastName, string gender, int phoneNumber, DateTime birthDate,
                          string adress, string certificates, string status, string department, string contactEmail, double fte, PositionType positionType)
              : base(BSN, firstName, LastName, gender, phoneNumber, birthDate, adress, certificates, status, department, contactEmail, fte, positionType)
        {

        }
    }
}
