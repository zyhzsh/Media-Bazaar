using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Store
    {
        private List<Employee> employees;
        private List<Product> products;
        
        public Store()
        {
            employees = new List<Employee>();
            products = new List<Product>();
            ProductMockData();
            AddEmployeeMockData();
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

        private void AddEmployeeMockData()
        {
            string format = "dd/MM/yyyy";
            var cultureInf = CultureInfo.InvariantCulture;
            AddEmployee(5467, "George", "Wood", 'M', "0031677777", DateTime.ParseExact("18/09/1997", format, cultureInf), "Eindhoven", "Administration ", "Employed", Departments.office, "g.wood@gmail.com", 1, PositionType.Administrator, "Administrator");
            AddEmployee(3456, "Nicole", "Green", 'F', "0031655378", DateTime.ParseExact("27/11/1998", format, cultureInf), "Geldrop", "IELTS", "Employed", Departments.warehouse, "n.green@gmail.com", 1, PositionType.Depot_Worker, "Depot_Worker");
            AddEmployee(7890, "John", "Doe", 'M', "0031674628", DateTime.ParseExact("05/12/1991", format, cultureInf), "Helmond", "Mangment ", "Employed", Departments.floorTwo, "john.d@gmail.com", 0.4, PositionType.Sales_Manager, "Sales Manager");
        }

        private void ProductMockData()
        {
            products.Add(new Product(1, "toaster", 9.99, 3.50, Departments.floorOne));
            products.Add(new Product(2, "fridge", 999, 150, Departments.floorOne));
            products.Add(new Product(3, "oukitel 35 pingus", 99, 13.50, Departments.floorTwo));
            products.Add(new Product(4, "Super Mario 3000", 49, 5.30, Departments.floorFour));
            products.Add(new Product(5, "ring bluetooth doorbell", 68.99, 9.99, Departments.floorThree));
        }

        public Product[] Products
        {
            get { return products.ToArray(); }
        }
    }
}

