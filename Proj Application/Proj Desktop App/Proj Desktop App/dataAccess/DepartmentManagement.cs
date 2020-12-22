using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Proj_Desktop_App.dataAccess
{
    class DepartmentManagement : DatabaseConnection
    {
        public DepartmentManagement() : base() { }

        public Department[] GetDepartments()
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        "SELECT * FROM department " +
                        "ORDER BY department_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<Department> departments = new List<Department>();
                    while (dr.Read())
                    {
                        Department department = new Department(
                                Convert.ToInt32(dr["department_id"]),
                                dr["department_name"].ToString());
                        departments.Add(department);
                    }
                    return departments.ToArray();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
