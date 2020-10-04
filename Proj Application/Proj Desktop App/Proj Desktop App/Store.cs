using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class Store
    {
        private List<Employee> employees;
        //private List<Product> products;
        
        public Store()
        {
            employees = new List<Employee>();
            //prducts = new List<Product>();
        }

        public bool AddEmployee(int BSN, string firstName, string LastName, string gender, int phoneNumber, DateTime birthDate,
            string adress, string certificates, string status, string department, string contactEmail, double fte, PositionType positionType)
        {
            employees.Add(new Employee(BSN, firstName, LastName, gender, phoneNumber, birthDate, adress, certificates, status, department, contactEmail, fte, positionType));
            return true;
        }

        




        private void AddMockData()
        {
           // AddEmployee(5467,"");
        }
    }
}
