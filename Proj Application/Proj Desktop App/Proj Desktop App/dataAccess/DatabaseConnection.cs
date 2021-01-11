using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Proj_Desktop_App.dataAccess
{
    public abstract class DatabaseConnection
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
