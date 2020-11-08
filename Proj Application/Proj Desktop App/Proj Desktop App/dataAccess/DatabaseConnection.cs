using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Proj_Desktop_App.dataAccess
{
    abstract class DatabaseConnection
    {
        private static string server = "studmysql01.fhict.local";
        private static string database = "dbi443880";
        private static string uid = "dbi443880";
        private static string password = "123456";

        private string connStr;

        public DatabaseConnection()
        {
            this.connStr = $"server={server};database={database};uid={uid};password={password};";
        }

        protected MySqlConnection GetConnection()
        {
            try
            {
                return new MySqlConnection(connStr);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to database.", "Error");
                return null;
            }
        }
    }
}
