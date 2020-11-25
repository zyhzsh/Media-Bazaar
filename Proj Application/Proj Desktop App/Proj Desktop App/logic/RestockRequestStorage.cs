using Proj_Desktop_App.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public class RestockRequestStorage
    {
        private List<RestockRequest> requests;
        private RestockRequestManagement reqMan;

        public RestockRequest[] Requests { get { return this.requests.ToArray(); } }
        public RestockRequestStorage()
        {
            requests = new List<RestockRequest>();
            reqMan = new RestockRequestManagement();
            LoadRestockRequests();
        }

        ///<summary>
        ///Reloads requests from the database
        ///</summary>
        private void LoadRestockRequests()
        {
            requests.Clear();
            foreach (RestockRequest req in reqMan.GetAllRestockRequests())
            {
                requests.Add(req);
            }
        }

        public bool Add(RestockRequest req)
        {
            if(req != null)
            {
                this.requests.Add(req);
                reqMan.CreateRestockRequest(req);
                LoadRestockRequests();
                return true;
            }
            else
            {
                return false;
            }
        }
        public RestockRequest GetRequest(int ID)
        {
            foreach (RestockRequest req in this.requests)
            {
                if (req.restockID == ID)
                    return req;
            }
            return null;
        }

        /// <summary>
        /// gets accepted restock requests
        /// </summary>
        /// <returns></returns>
        public RestockRequest[] GetAccepted()
        {
            try
            {
                List<RestockRequest> acceptedRequests = new List<RestockRequest>();
                foreach(RestockRequest req in this.requests)
                {
                    if(req != null) 
                        if (req.status == "ACCEPTED")
                            acceptedRequests.Add(req);
                }
                return acceptedRequests.ToArray();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        /// <summary>
        /// gets pending restock requests
        /// </summary>
        /// <returns></returns>
        public RestockRequest[] GetPending()
        {
            LoadRestockRequests();
            try
            {
                List<RestockRequest> pendingRequests = new List<RestockRequest>();
                foreach (RestockRequest req in this.requests)
                {
                    if (req != null)
                        if (req.status == "PENDING")
                            pendingRequests.Add(req);
                }
                return pendingRequests.ToArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public RestockRequest[] GetPending(Departments department)
        {
            LoadRestockRequests();
            try
            {
                List<RestockRequest> pendingRequests = new List<RestockRequest>();
                foreach (RestockRequest req in this.requests)
                {
                    if (req != null)
                        if (req.status == "PENDING")
                            pendingRequests.Add(req);
                }
                return pendingRequests.ToArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }


        /// <summary>
        /// Rejects request with {restockId}
        /// </summary>
        public void Decline(int restockId, int judgeBSN, string judge_desc)
        {
            RestockRequest req = GetRequest(restockId);
            req.DeclineRequest(judgeBSN, judge_desc);
            reqMan.DeclineRestockRequest(restockId, judgeBSN, judge_desc);
        }
        /// <summary>
        /// Accepts request with {restockId}
        /// </summary>
        public void Accept(int restockId, int judgeBSN, string judge_desc)
        {
            RestockRequest req = GetRequest(restockId);
            req.AcceptRequest(judgeBSN, judge_desc);
            reqMan.AcceptRestockRequest(restockId, judgeBSN, judge_desc);
        }
        public void CompleteRequest(int restockId, int workerBSN, int restockedAmount, string worker_report)
        {
            RestockRequest req = GetRequest(restockId);
            req.CompleteRequest(workerBSN, worker_report);
            reqMan.RestockProduct(req, workerBSN, restockedAmount, worker_report);
        }
    }
}
