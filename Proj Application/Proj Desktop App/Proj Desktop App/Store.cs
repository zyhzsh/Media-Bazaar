﻿using System;
using System.Collections.Generic;
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
            ProductMockData();
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

        private void ProductMockData()
        {
            products.Add(new Product( "toaster", "Tristar",9.99, 3.50, Departments.floorOne));
            products.Add(new Product( "fridge", "Tristar",999, 150, Departments.floorOne));
            products.Add(new Product( "oukitel 35 pingus", "Oukitel",99, 13.50, Departments.floorTwo));
            products.Add(new Product( "Super Mario 3000", "Nontaido",49, 5.30, Departments.floorFour));
            products.Add(new Product( "Ring bluetooth doorbell", "Ring",68.99, 9.99, Departments.floorThree));
        }

        public Product[] Products
        {
            get { return products.ToArray(); }
        }
        public Product Product(int productId)
        {
            foreach (Product p in products)
            {
                if (p.Id == productId)
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
            Product(productId).Restock(amount);
            for (int i = orders.Count - 1; i >= 0; i--)
            {
                if (orders[i].GetProductId == productId)
                {
                    orders.RemoveAt(i);
                }
            }
        }

        public void AcceptRestock(RestockRequest order)
        {
            orders.Add(order);
            requests.Remove(order);
        }

        public void AddRestock(int productId, string productName,int restockAmount)
        {
            requests.Add(new RestockRequest(productId, productName, restockAmount));
        }

        public void RemoveRestock(int productId)
        {
            for (int i = requests.Count - 1; i >= 0; i--)
            {
                if (requests[i].GetProductId == productId)
                {
                    requests.RemoveAt(i);
                }
            }
        }

        public void AddProduct(string productName, string brandName, double sellingPrice, double buyingPrice, Departments department)
        {
            products.Add(new Product(productName, brandName, sellingPrice, buyingPrice, department));
        }

        public void UpdateProduct(int productId, string productName, string brandName, double sellingPrice, double buyingPrice, Departments department, string description)
        {
            Product(productId).Update(productName, brandName, sellingPrice, buyingPrice, department, description);
        }
        public void RemoveProduct(int productId)
        {
            for (int i = products.Count - 1; i >= 0; i--)
            {
                if (products[i].Id == productId)
                {
                    products.RemoveAt(i);
                }
            }
        }
    }
}
