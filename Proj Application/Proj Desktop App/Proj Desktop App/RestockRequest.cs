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
        public int judgeBsn { get; private set; }
        public string requesterName { get; private set; }
        public int restockAmount { get; private set; }
        public string requester_desc { get; private set; }
        public string judge_desc { get; private set; }
        public RestockRequest(int productCode, string name, int requesterBsn, int RestockAmount, string description)
        {
            //Used when adding new requests to database
            this.productCode = productCode;
            this.productName = name;
            this.requesterBsn = requesterBsn;
            this.restockAmount = RestockAmount;
            this.requester_desc = description;
        }

        public RestockRequest(int restockId, int productCode, string name, int requesterBsn, int judgeBsn, int restockAmount, string requester_desc, string judge_desc)
        {
            //Used when getting accepted requests
            this.restockID = restockId;
            this.productCode = productCode;
            this.productName = name;
            this.requesterBsn = requesterBsn;
            this.judgeBsn = judgeBsn;
            this.restockAmount = restockAmount;
            this.requester_desc = requester_desc;
            this.judge_desc = judge_desc;
        }

        public override string ToString()
        {
            return $"{productName} needs {restockAmount} additional units, {requester_desc}";
        }
    }
}
