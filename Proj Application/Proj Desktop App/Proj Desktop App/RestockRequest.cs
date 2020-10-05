using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.X509;

namespace Proj_Desktop_App
{
    public class RestockRequest
    {
        private int productId;
        private string productName;
        private int restockAmount;

        public RestockRequest(int Id, string name, int RestockAmount)
        {
            productId = Id;
            productName = name;
            restockAmount = RestockAmount;
        }

        public int GetProductId
        {
            get { return productId; }
        }

        public int GetRestockAmount
        {
            get { return restockAmount; }
        }

        public override string ToString()
        {
            return $"{productName} needs {restockAmount} additional units";
        }
    }
}
