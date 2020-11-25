using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Proj_Desktop_App.dataAccess;

namespace Proj_Desktop_App
{
    class LoginHandler : DatabaseConnection
    {
        public LoginHandler() : base() { }

        public int Login(string username, string password)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "SELECT BSN FROM employee WHERE username = @username AND password = @password;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    int bsn = -1;
                    if (dr.Read())
                    {
                        bsn = Convert.ToInt32(dr["BSN"]);
                    }

                    return bsn;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Something went wrong!");
                return -1;
            }
        }
    }
}
