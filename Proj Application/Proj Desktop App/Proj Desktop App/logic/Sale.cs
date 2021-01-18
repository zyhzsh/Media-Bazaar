using System;

namespace Proj_Desktop_App
{
    public class Sale:IComparable<Sale>
    {
        public int ProductCode { get; private set; }
        public string ProductName { get; private set; }
        public int SoldAmount { get; private set; }
        public string Departmentname { get; private set; }
        public string Brand { get;private set; }
        public Sale(int productCode, string productName, int soldAmount,string departmentname,string brand)
        {
            ProductCode = productCode;
            ProductName = productName;
            SoldAmount = soldAmount;
            Departmentname = departmentname;
            Brand = brand;
        }

        public override string ToString()
        {
            return $"{ProductName} with product code: {ProductCode} sold {SoldAmount} From {Departmentname}";
        }

        public int CompareTo(Sale other)
        {
            return this.SoldAmount.CompareTo(other.SoldAmount);
        }
    }
}
