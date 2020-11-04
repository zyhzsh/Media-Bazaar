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
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public double SellingPrice { get; private set; }
        public double BuyingPrice { get; private set; }
        public string Description { get; private set; }
        public int Stock { get; private set; }
        public Departments Department { get; private set; }

        public Product(string name, string brand, double sell, double buy, Departments department)
        {
            id = incrementCode++;
            Name = name;
            Brand = brand;
            SellingPrice = sell;
            BuyingPrice = buy;
            Department = department;
            Stock = 0;
        }

        public Product(string name, string brand, double sell, double buy, string Description,Departments department)
        {
            id = incrementCode++;
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
        }

        public override string ToString()
        {
            return $"id: {id} - {Name} - sold for {SellingPrice} from {Department} | {Stock} in stock";
        }
    }
}
