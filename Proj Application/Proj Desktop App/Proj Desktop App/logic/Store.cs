using Proj_Desktop_App.dataAccess;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public delegate void EmployeeHandler(Employee employee);

    public class Store
    {
        private List<Employee> employees;
        private List<Product> products;
        private List<RestockRequest> requests;
        private List<RestockRequest> orders;

        EmployeeManagement emplMan;
        public event EmployeeHandler EmployeeChanged;

        public Store()
        {
            this.employees = new List<Employee>();
            products = new List<Product>();
            requests = new List<RestockRequest>();
            orders = new List<RestockRequest>();
            //AddEmployeeMockData();
            //InitializeProducts();
            ProductManagement dtbManagement = new ProductManagement();
            emplMan = new EmployeeManagement();
            Employee[] employees = emplMan.GetAllEmployees();
            if (employees != null)
            {
                this.employees.AddRange(employees);
            }

            ContractManagement contrMan = new ContractManagement();
            foreach (Employee employee in employees)
            {
                Contract[] contracts = contrMan.GetAllContracts(employee.GetBSN());
                employee.AddContracts(contracts);
            }
        }

        /// <summary>
        /// Add a new employee
        /// </summary>
        public bool AddEmployee(int BSN, string firstName, string lastName, char gender, DateTime birthDate,
            string languages, string certificates, string phoneNumber, string address, string contactEmail,
            DateTime startDate, DateTime endDate, PositionType position, Departments department, decimal fte)
        {
            if (GetEmployee(BSN) == null)
            {
                Employee employee = new Employee(BSN, firstName, lastName, gender, birthDate, languages, certificates, phoneNumber, address, contactEmail, startDate, endDate, position, department, fte);
                // Add employee to database
                if (emplMan.AddEmployee(employee))
                {
                    // Add employee locally
                    employees.Add(employee);
                    EmployeeChanged(employee);
                    return true;
                }
                else
                {
                    throw new Exception("Failed to add employee");
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Update employee details
        /// </summary>
        public bool UpdateEmployee(int BSN, string firstName, string lastName, char gender, string languages,
            string certificates, string phoneNumber, string address, string contactEmail)
        {
            Employee employee = GetEmployee(BSN);
            if (employee != null)
            {
                // Update employee locally
                employee.UpdateInfo(firstName, lastName, gender, languages, certificates,
                         phoneNumber, address, contactEmail);
                // Update employee in database
                if (emplMan.UpdateEmployee(employee))
                {
                    EmployeeChanged(employee);
                    return true;
                }
                else
                {
                    throw new Exception("Failed to update employee");
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get an employee based on their BSN
        /// </summary>
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


        /// <summary>
        /// Get employees by partial bsn
        /// </summary>
        public Employee[] GetEmployees(bool onlyEmployed, int bsn)
        {
            List<Employee> employees = new List<Employee>();
            foreach (Employee empl in GetEmployees(onlyEmployed))
            {
                if (empl.GetBSN().ToString().Contains(bsn.ToString()))
                {
                    employees.Add(empl);
                }
            }
            return employees.ToArray();
        }

        /// <summary>
        /// Get employees by partial name
        /// </summary>
        public Employee[] GetEmployees(bool onlyEmployed, string name)
        {
            List<Employee> employees = new List<Employee>();
            foreach (Employee empl in GetEmployees(onlyEmployed))
            {
                string fullName = $"{empl.firstName} {empl.lastName}".ToLower(); ;
                if ((fullName).Contains(name.ToLower()))
                {
                    employees.Add(empl);
                }
            }
            return employees.ToArray();
        }

        /// <summary>
        /// Get all / only employed employees
        /// </summary>
        public Employee[] GetEmployees(bool onlyEmployed)
        {
            if (onlyEmployed)
            {
                List<Employee> employees = new List<Employee>();
                foreach (Employee empl in this.employees)
                {
                    if (empl.IsEmployed() == onlyEmployed)
                    {
                        employees.Add(empl);
                    }
                }
                return employees.ToArray();
            }
            else
            {
                return this.employees.ToArray();
            }
        }

        /// <summary>
        /// Get employees by department
        /// </summary>
        public Employee[] GetEmployees(Departments department)
        {
            List<Employee> temp = new List<Employee>();
            foreach(Employee e in employees)
            {
                if (e.IsEmployed() == true && e.GetDepartment() == department)
                {
                    temp.Add(e);
                }
            }
            return temp.ToArray();
        }

        private void AddEmployeeMockData()
        {
            string format = "dd/MM/yyyy";
            var cultureInf = CultureInfo.InvariantCulture;
            AddEmployee(5467, "George", "Wood", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf),"", "", "0031677777", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Administrator, Departments.office, 1);
            AddEmployee(7890, "Nicole", "Green", 'F', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "0031674628", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Sales_Worker, Departments.floorTwo, 0.5m);
            AddEmployee(3992616, "Shenghang", "Zhu", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "3992616", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Sales_Manager, Departments.floorFour, 1);
            AddEmployee(3376540, "David", "van Rijthoven", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "3376540", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Depot_Manager, Departments.warehouse, 1);
            AddEmployee(4090918, "Martin", "Dzhurov", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "4090918", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Administrator, Departments.office, 1);
            AddEmployee(443892, "Mohammed", "Al-Eryani", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "443892", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Sales_Manager, Departments.floorOne, 1);
            AddEmployee(3088685, "Joost", "Burggraaff", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "3088685", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Depot_Worker, Departments.warehouse, 1);
        }

        private void InitializeProducts()
        {
            ProductManagement dtbMan = new ProductManagement();
            Product[] dtbproducts;
            dtbproducts = dtbMan.GetAllProducts();
            foreach(Product p in dtbproducts)
            {
                products.Add(p);
            }
        }

        public Product[] Products
        {
            get { return products.ToArray(); }
        }
        public Product Product(int productId)
        {
            foreach (Product p in products)
            {
                if (p.id == productId)
                {
                    return p;
                }
            }
            MessageBox.Show("Product not found");
            throw new Exception("product id does not exist");
        }
        public RestockRequest[] GetRestockRequests
        {
            get { return requests.ToArray(); }
        }

        public RestockRequest[] GetRestockOrders
        {
            get { return orders.ToArray(); }
        }

        public void RestockProduct(int productId, int amount)
        {
            /*
            DatabaseManagement dtbMan = new DatabaseManagement();
            dtbMan.RestockProduct()
            Product(productId).Restock(amount);
            for (int i = orders.Count - 1; i >= 0; i--)
            {
                if (orders[i].productCode == productId)
                {
                    orders.RemoveAt(i);
                }
            }
            */
        }

        public void AcceptRestock(RestockRequest order)
        {
            orders.Add(order);
            requests.Remove(order);
        }

        public void AddRestock(int productId, string productName,int restockAmount, string description)
        {
            //requests.Add(new RestockRequest(productId, productName, restockAmount, description));
        }

        public void RemoveRestock(int productId)
        {
            for (int i = requests.Count - 1; i >= 0; i--)
            {
                if (requests[i].productCode == productId)
                {
                    requests.RemoveAt(i);
                }
            }
        }

        public void AddProduct(string productName, string brandName, double sellingPrice, double buyingPrice, Departments department)
        {
            ProductManagement dtbMan = new ProductManagement();
            dtbMan.AddProduct(department, productName, brandName, buyingPrice, sellingPrice);
        }

        public void UpdateProduct(int productId, string productName, string brandName, double sellingPrice, double buyingPrice, Departments department, string description)
        {
            Product(productId).Update(productName, brandName, sellingPrice, buyingPrice, department, description);
        }
        public void RemoveProduct(int productId)
        {
            for (int i = products.Count - 1; i >= 0; i--)
            {
                if (products[i].id == productId)
                {
                    products.RemoveAt(i);
                }
            }
        }
    }
}

