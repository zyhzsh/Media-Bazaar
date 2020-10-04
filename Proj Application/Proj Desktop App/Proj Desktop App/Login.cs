using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class Login
    {
        public PositionType CheckPossition { get; private set; }

        public Login()
        {

        }

        public bool CheckLogin(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                CheckPossition = PositionType.Administrator;
                return true;
            }
            else if (username == "depot_manager" && password == "depot_manager")
            {
                CheckPossition = PositionType.Depot_Manager;
                return true;
            }
            else if (username == "sales_manager" && password == "sales_manager")
            {
                CheckPossition = PositionType.Sales_Manager;
                return true;
            }
            else if (username == "depot_worker" && password == "depot_worker")
            {
                CheckPossition = PositionType.Depot_Worker;
                return true;
            }
            else { return false; }
        }
    }
}
