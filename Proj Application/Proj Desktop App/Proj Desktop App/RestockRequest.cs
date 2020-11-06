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
        public int restockID { get; private set; }
        public int productCode { get; private set; }
        public string productName { get; private set; }
        public int requesterBsn { get; private set; }
        public string requesterName { get; private set; }
        public int restockAmount { get; private set; }
        public string description { get; private set; }

        public RestockRequest(int restockID ,int productCode, string name, int requesterBsn, int RestockAmount, string description)
        {
            this.restockID = restockID;
            this.productCode = productCode;
            productName = name;
            restockAmount = RestockAmount;
            this.description = description;
            this.requesterBsn = requesterBsn;
        }

        public override string ToString()
        {
            return $"{productName} needs {restockAmount} additional units, {description}";
        }
    }
}
