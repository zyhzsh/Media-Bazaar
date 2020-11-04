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
<<<<<<< HEAD
        public int restockID { get; private set; }
        public int productCode { get; private set; }
        public string productName { get; private set; }

        public string requesterName { get; private set; }
        public int restockAmount { get; private set; }
        public string description { get; private set; }

        public RestockRequest(int restockID ,int productCode, string name, int RestockAmount, string description)
        {
            this.restockID = restockID;
            this.productCode = productCode;
            productName = name;
            restockAmount = RestockAmount;
            this.description = description;
=======
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
>>>>>>> website
        }

        public override string ToString()
        {
<<<<<<< HEAD
            return $"{productName} needs {restockAmount} additional units, {description}";
=======
            return $"{productName} needs {restockAmount} additional units";
>>>>>>> website
        }
    }
}
