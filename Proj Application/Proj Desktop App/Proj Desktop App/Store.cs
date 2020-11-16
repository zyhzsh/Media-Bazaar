using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public class Store
    {
        private List<Employee> employees;
        private List<Product> products;
        private List<RestockRequest> requests;
        private List<RestockRequest> orders;

        public Store()
        {
            employees = new List<Employee>();
            products = new List<Product>();
            requests = new List<RestockRequest>();
            orders = new List<RestockRequest>();
            //AddEmployeeMockData();
            InitializeProducts();
            DatabaseManagement dtbManagement = new DatabaseManagement();
            employees.AddRange(dtbManagement.GetAllEmployees());
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
        public Employee[] GetEmployeeList()
        {
            return this.employees.ToArray();
        }


        public Employee[] GetEmployeeList(Departments department)
        {
            List<Employee> temp = new List<Employee>();
            foreach(Employee e in employees)
            {
                if (e.department == department)
                {
                    temp.Add(e);
                }
            }
            return temp.ToArray();
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
            AddEmployee(3992616, "Shenghang", "Zhu", 'M', "134556", DateTime.ParseExact("01/01/2020", format, cultureInf), "Tilburg", "ICT", "employed", Departments.warehouse, "xxxx@gmail.com", 1, PositionType.Depot_Worker, "");
            AddEmployee(3376540, "David", "van Rijthoven ", 'M', "134556", DateTime.ParseExact("01/01/2020", format, cultureInf), "Eindhoven", "ICT", "employed", Departments.floorOne, "xxxx@gmail.com", 1, PositionType.Sales_Worker, "");
            AddEmployee(4090918, "Dzhurov", "M", 'M', "134556", DateTime.ParseExact("01/01/2020", format, cultureInf), "Amersfoort", "ICT", "employed", Departments.floorOne, "xxxx@gmail.com", 1, PositionType.Depot_Worker, "");
            AddEmployee(443892, "Mohammed", "Al-Eryani", 'M', "134556", DateTime.ParseExact("01/01/2020", format, cultureInf), "Den Haag", "ICT", "employed", Departments.floorFour, "xxxx@gmail.com", 1, PositionType.Sales_Worker, "");
            AddEmployee(3088685, "Joost", "Burggraaff", 'M', "134556", DateTime.ParseExact("01/01/2020", format, cultureInf), "Eindhoven", "ICT", "employed", Departments.floorThree, "xxxx@gmail.com", 1, PositionType.Depot_Worker, "");
        }

        private void InitializeProducts()
        {
            DatabaseManagement dtbMan = new DatabaseManagement();
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
            DatabaseManagement dtbMan = new DatabaseManagement();
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

