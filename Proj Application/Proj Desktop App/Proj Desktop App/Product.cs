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
<<<<<<< HEAD
        public int id { get; }
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public double SellingPrice { get; private set; }
        public double BuyingPrice { get; private set; }
        public string Description { get; private set; }
        public int Stock { get; private set; }
        public Departments Department { get; private set; }
=======
        private int id;
        private string name;
        private string brand;
        private double sellingPrice;
        private double buyingPrice;
        private string description;
        private int stock;
        private Departments belongingDepartment;
>>>>>>> website

        public Product(string name, string brand, double sell, double buy, Departments department)
        {
            id = incrementCode++;
<<<<<<< HEAD
            Name = name;
            Brand = brand;
            SellingPrice = sell;
            BuyingPrice = buy;
            Department = department;
            Stock = 0;
=======
            this.name = name;
            this.brand = brand;
            sellingPrice = sell;
            buyingPrice = buy;
            belongingDepartment = department;
            stock = 0;
>>>>>>> website
        }

        public Product(string name, string brand, double sell, double buy, string Description,Departments department)
        {
            id = incrementCode++;
<<<<<<< HEAD
            Name = name;
            Brand = brand;
            SellingPrice = sell;
            BuyingPrice = buy;
            this.Description = Description;
            Department = department;
            Stock = 0;
        }


        public void Update(string productName, string brandName, double sell, double buy, Departments department, string Description)
        {
            Name = productName;
            Brand = brandName;
            SellingPrice = sell;
            BuyingPrice = buy;
            Department = department;
            this.Description = Description;
=======
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
>>>>>>> website
        }

        public override string ToString()
        {
<<<<<<< HEAD
            return $"id: {id} - {Name} - sold for {SellingPrice} from {Department} | {Stock} in stock";
=======
            return $"id: {id} - {name} - sold for {sellingPrice} from {belongingDepartment} | {stock} in stock";
>>>>>>> website
        }
    }
}
