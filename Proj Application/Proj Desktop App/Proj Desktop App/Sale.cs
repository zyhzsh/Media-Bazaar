using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class Sale
    {
        public int productCode { get; private set; }
        public string productName { get; private set; }
        public int soldAmount { get; private set; }
        public Sale(int productCode, string productName, int soldAmount)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.soldAmount = soldAmount;
        }

        public override string ToString()
        {
            return $"{productName} with product code: {productCode} sold {soldAmount}";
        }
    }
}
