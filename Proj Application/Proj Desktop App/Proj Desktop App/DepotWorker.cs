using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class DepotWorker:Employee
    {
        public DepotWorker(int BSN, string firstName, string LastName, char gender, string phoneNumber, DateTime birthDate,
                  string adress, string certificates, string status, Departments department, string contactEmail, double fte, PositionType positionType, string jobTitle)
              : base(BSN, firstName, LastName, gender, phoneNumber, birthDate, adress, certificates, status, department, contactEmail, fte, positionType, jobTitle)
        {

        }
    }
}
