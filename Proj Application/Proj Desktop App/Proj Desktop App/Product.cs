using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class Product
    {
        private int productCode;
        private string productName;
        private double sellingPrice;
        private double buyingPrice;
        private int stock;
        private Departments belongingDepartment;

        public Product(int code, string name, double sell, double buy, Departments department)
        {
            productCode = code;
            productName = name;
            sellingPrice = sell;
            buyingPrice = buy;
            belongingDepartment = department;
            stock = 0;
        }

        public int ProductCode
        {
            get { return productCode; }
        }

        public string ProductName
        {
            get { return productName; }
        }

        private void Restock()
        {
            stock += 20;
        }

        public override string ToString()
        {
            return $"code: {productCode} - {productName} - sold for {sellingPrice} from {belongingDepartment}";
        }
    }
}
