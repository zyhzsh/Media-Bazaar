namespace Proj_Desktop_App
{
    public class RestockRequest
    {
        public int restockID { get; private set; }
        public int productCode { get; private set; }
        public string productName { get; private set; }
        public Department productDepartment { get; private set; }
        public int requesterBsn { get; private set; }
        public int judgeBsn { get; private set; }
        public int workerBsn { get; private set; }
        public string requesterName { get; private set; }
        public int restockAmount { get; private set; }
        public string requester_desc { get; private set; }
        public string judge_desc { get; private set; }
        public string worker_desc { get; private set; }

        public string status { get; private set; }
        /// <summary>
        /// Used when adding new requests to database
        /// </summary>
        public RestockRequest(int productCode, string name, Department productDepartment, int requesterBsn, int RestockAmount, string description, string status)
        {
            this.productCode = productCode;
            this.productName = name;
            this.productDepartment = productDepartment;
            this.requesterBsn = requesterBsn;
            this.restockAmount = RestockAmount;
            this.requester_desc = description;
            this.status = status;
        }

        /// <summary>
        /// Used when getting pending requests from database
        /// </summary>
        public RestockRequest(int restockID, int productCode, string name, Department productDepartment, int requesterBsn, int RestockAmount, string description, string status)
        {
            this.restockID = restockID;
            this.productCode = productCode;
            this.productName = name;
            this.productDepartment = productDepartment;
            this.requesterBsn = requesterBsn;
            this.restockAmount = RestockAmount;
            this.requester_desc = description;
            this.status = status;
        }

        /// <summary>
        /// Used when getting judged requests from database
        /// </summary>
        public RestockRequest(int restockId, int productCode, string name, Department productDepartment, int requesterBsn, int judgeBsn, int restockAmount, string requester_desc, string judge_desc, string status)
        {
            this.restockID = restockId;
            this.productCode = productCode;
            this.productName = name;
            this.productDepartment = productDepartment;
            this.requesterBsn = requesterBsn;
            this.judgeBsn = judgeBsn;
            this.restockAmount = restockAmount;
            this.requester_desc = requester_desc;
            this.judge_desc = judge_desc;
            this.status = status;
        }

        /// <summary>
        /// Used when getting completed requests from database
        /// </summary>
        public RestockRequest(int restockId, int productCode, string name, Department productDepartment, int requesterBsn, int judgeBsn, int workerBsn, int restockAmount, string requester_desc, string judge_desc, string worker_desc, string status)
        {
            this.restockID = restockId;
            this.productCode = productCode;
            this.productName = name;
            this.productDepartment = productDepartment;
            this.requesterBsn = requesterBsn;
            this.judgeBsn = judgeBsn;
            this.workerBsn = workerBsn;
            this.restockAmount = restockAmount;
            this.requester_desc = requester_desc;
            this.judge_desc = judge_desc;
            this.worker_desc = worker_desc;
            this.status = status;
        }

        public void DeclineRequest(int judgeBsn, string judge_desc)
        {
            this.judgeBsn = judgeBsn;
            this.judge_desc = judge_desc;
            this.status = "DECLINED";
        }
        public void AcceptRequest(int judgeBsn, string judge_desc)
        {
            this.judgeBsn = judgeBsn;
            this.judge_desc = judge_desc;
            this.status = "ACCEPTED";
        }
        /// <summary>
        /// Complete restock request
        /// </summary>
        public void CompleteRequest(int workerBsn, string worker_report)
        {
            this.workerBsn = workerBsn;
            this.worker_desc = worker_report;
            this.status = "COMPLETED";
        }

        public override string ToString()
        {
            return $"{productName} needs {restockAmount} additional units, {requester_desc}";
        }
    }
}
