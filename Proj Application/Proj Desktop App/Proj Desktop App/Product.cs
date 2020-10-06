using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Product
    {
        private static int incrementCode = 1;
        private int id;
        private string name;
        private string brand;
        private double sellingPrice;
        private double buyingPrice;
        private string description;
        private int stock;
        private Departments belongingDepartment;

        public Product(string name, string brand, double sell, double buy, Departments department)
        {
            id = incrementCode++;
            this.name = name;
            this.brand = brand;
            sellingPrice = sell;
            buyingPrice = buy;
            belongingDepartment = department;
            stock = 0;
        }

        public Product(string name, string brand, double sell, double buy, string Description,Departments department)
        {
            id = incrementCode++;
            this.name = name;
            this.brand = brand;
            sellingPrice = sell;
            buyingPrice = buy;
            description = Description;
            belongingDepartment = department;
            stock = 0;
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Brand
        {
            get { return brand; }
            private set { brand = value; }
        }

        public double SellingPrice
        {
            get { return sellingPrice; }
            private set { sellingPrice = value; }
        }

        public double BuyingPrice
        {
            get { return buyingPrice; }
            private set { buyingPrice = value; }
        }

        public Departments Department
        {
            get { return belongingDepartment; }
            private set { belongingDepartment = value; }
        }

        public string Description
        {
            get { return description; }
        }
        public void Restock(int restock)
        {
            stock += restock;
        }

        public void Update(string productName, string brandName, double sell, double buy, Departments department, string Description)
        {
            name = productName;
            brand = brandName;
            sellingPrice = sell;
            buyingPrice = buy;
            belongingDepartment = department;
            description = Description;
        }

        public override string ToString()
        {
            return $"id: {id} - {name} - sold for {sellingPrice} from {belongingDepartment} | {stock} in stock";
        }
    }
}
