using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class Manager : Employee
    {
        string managerSpecificInfo;

        public Manager(int BSN, string firstName, string LastName, char gender, string phoneNumber, DateTime birthDate,
                  string adress, string certificates, string status, Departments department, string contactEmail, double fte, string managerSpecificInfo,PositionType positionType, string jobTitle)
      : base(BSN, firstName, LastName, gender, phoneNumber, birthDate, adress, certificates, status, department, contactEmail, fte, positionType, jobTitle)
        {
            this.managerSpecificInfo = managerSpecificInfo;
        }
    }
}
