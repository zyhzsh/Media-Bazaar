﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj_Desktop_App.dataAccess;

namespace Proj_Desktop_App
{
    class RequestChangeStorage
    {
        private List<RequestInfoChange> requestInfoChanges;
        private EmployeeManagement empMan;

        /// <summary>
        /// gets all request currently stored
        /// </summary>
       // public RequestInfoChange[] requests { get { return this.requestInfoChanges.ToArray(); } }
        public RequestChangeStorage()
        {
            requestInfoChanges = new List<RequestInfoChange>();
            empMan = new EmployeeManagement();
            LoadProducts();
        }
        ///<summary>
        ///Reloads requestes from the database into storage
        ///</summary>
        private void LoadProducts()
        {
            RequestInfoChange[] tempRequests = empMan.GetAllEmployeesrequests();
            if (tempRequests != null)
            {
                this.requestInfoChanges.AddRange(tempRequests);
            }
        }
        public RequestInfoChange[] GetRequestInfoChanges()
        {
            return requestInfoChanges.ToArray();
        }
        public Employee GetEmployeeByBsn(int bsn)
        {
            return empMan.GetEmployee(bsn);
        }
        public void DeleteRequest(int bsn)
        {
            empMan.DeleteRequest(bsn);
        }
    }
}
