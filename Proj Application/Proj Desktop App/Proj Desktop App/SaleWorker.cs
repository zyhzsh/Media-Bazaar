using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class SaleWorker : Employee
    {
        private string language;
        public SaleWorker(int BSN, string firstName, string LastName, char gender, string phoneNumber, DateTime birthDate,
                  string adress, string certificates, string status, Departments department, string contactEmail, double fte, PositionType positionType, string jobTitle, string language)
              : base(BSN, firstName, LastName, gender, phoneNumber, birthDate, adress, certificates, status, department, contactEmail, fte, positionType, jobTitle)
        {
            this.language = language;
        }
    }
}