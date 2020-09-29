using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Store
    {
        private List<Employee> employees;
        //private List<Product> products;
        
        public Store()
        {
            employees = new List<Employee>();
            //prducts = new List<Product>();
            AddMockData();
        }

        public bool AddEmployee(int BSN, string firstName, string lastName, char gender, string phoneNumber, DateTime birthDate,
            string address, string certificates, string status, Departments department, string contactEmail,
            double fte, PositionType positionType, string jobTitle)
        {
            if (GetEmployee(BSN) == null)
            {
                employees.Add(new Employee(BSN, firstName, lastName, gender, phoneNumber, birthDate, address, certificates, status, department, contactEmail, fte, positionType, jobTitle));
                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee GetEmployee(int bsn)
        {
            foreach (Employee employee in employees)
            {
                if (bsn == employee.GetBSN())
                {
                    return employee;
                }
            }
            return null;
        }

        public string[] GetEmployees()
        {
            List<string> employeeInfos = new List<string>();
            foreach (Employee employee in employees)
            {
                employeeInfos.Add(employee.GetInfo());
            }
            return employeeInfos.ToArray();
        }






        private void AddMockData()
        {
            AddEmployee(5467, "George", "Wood", 'M', "0031677777", DateTime.Parse("18/09/1997"), "Eindhoven", "Administration ", "Employed", Departments.office, "g.wood@gmail.com", 1, PositionType.Administrator, "Administrator");
            AddEmployee(3456, "Nicole", "Green", 'F', "0031655378", DateTime.Parse("27/11/1990"), "Geldrop", "IELTS", "Employed", Departments.warehouse, "n.green@gmail.com", 1, PositionType.Depot_Worker, "Depot_Worker");
            AddEmployee(7890, "john", "doe", 'M', "0031674628", DateTime.Parse("05/07/1995"), "Helmond", "Mangment ", "Employed", Departments.floorTwo, "john.d@gmail.com", 0.4, PositionType.Sales_Manager, "Sales Manager");
        }
    }
}
