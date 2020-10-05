using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class Login
    {
        public Login()
        {

        }

        public PositionType CheckLogin(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return PositionType.Administrator;
            }
            else if (username == "depot_manager" && password == "depot_manager")
            {
                return PositionType.Depot_Manager;
            }
            else if (username == "sales_manager" && password == "sales_manager")
            {
                return PositionType.Sales_Manager;
            }
            else if (username == "depot_worker" && password == "depot_worker")
            {
                return PositionType.Depot_Worker;
            }
            else { return PositionType.Other; }
        }
    }
}
