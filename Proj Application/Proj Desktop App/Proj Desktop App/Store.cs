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
        private List<Product> products;
        
        public Store()
        {
            employees = new List<Employee>();
            products = new List<Product>();
            ProductMockData();
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
