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
        public int id { get; }
        public string name { get; private set; }
        public string brand { get; private set; }
        public double sellingPrice { get; private set; }
        public double buyingPrice { get; private set; }
        public string description { get; private set; }
        public int stock { get; private set; }
        public Departments belongingDepartment { get; private set; }

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
