using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Proj_Desktop_App
{
    class LoginHandler
    {
        private string connStr;

        public LoginHandler()
        {
            connStr = "server=studmysql01.fhict.local;database=dbi443880;uid=dbi443880;password=123456;";
        }

        public PositionType CheckLogin(string username, string password)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "SELECT position_name FROM position WHERE position_id IN (SELECT c.position_id FROM contract c INNER JOIN employee e ON c.BSN = e.BSN WHERE e.username = @username AND e.password = @password);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    string positionStr = "";
                    if ( dr.Read() )
                    { 
                        positionStr = dr[0].ToString();
                    }

                    if (positionStr == "Administrator")
                    {
                        return PositionType.Administrator;
                    }
                    else if (positionStr == "DepotManager")
                    {
                        return PositionType.Depot_Manager;
                    }
                    else if (positionStr == "SalesManager")
                    {
                        return PositionType.Sales_Manager;
                    }
                    else if (positionStr == "DepotWorker")
                    {
                        return PositionType.Depot_Worker;
                    }
                    else
                    {
                        return PositionType.Other;
                    }
                }
            }
            catch (Exception)
            {
                return PositionType.Other;
            }
        }
    }
}
