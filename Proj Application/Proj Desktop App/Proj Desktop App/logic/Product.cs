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
        public int id { get; }
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public double SoldPrice { get; private set; }
        public double BoughtPrice { get; private set; }
        public int Stock { get; private set; }
        public string Description { get; private set; }
        public Department Department { get; private set; }

        public Product(int productCode, string name, string brand, double sell, double buy, string description, Department department, int current_stock)
        {
            this.id = productCode;
            Name = name;
            Brand = brand;
            SoldPrice = sell;
            BoughtPrice = buy;
            Description = description;
            Department = department;
            Stock = current_stock;
        }

        public void Update(string productName, string brandName, double buy, double sell, Department department)
        {
            Name = productName;
            Brand = brandName;
            SoldPrice = sell;
            BoughtPrice = buy;
            Department = department;
        }
        public void Update(string productName, string brandName, double buy, double sell, Department department, string Description)
        {
            Name = productName;
            Brand = brandName;
            SoldPrice = sell;
            BoughtPrice = buy;
            Department = department;
            this.Description = Description;
        }

        public override string ToString()
        {
            return $"id: {id} - {Name} - sold for {SoldPrice}€ from {Department} | {Stock} in stock";
        }
    }
}
