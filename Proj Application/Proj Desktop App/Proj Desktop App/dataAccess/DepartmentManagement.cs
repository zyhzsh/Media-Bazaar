using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
                                dr["department_name"].ToString(),
                                Convert.ToBoolean(dr["sells_products"]));
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

        public int GetLatestDepartmentId()
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        "SELECT department_id " +
                        "FROM department " +
                        "ORDER BY department_id DESC " +
                        "LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        return Convert.ToInt32(dr["department_id"]);
                    }
                    else { return -1; }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public bool AddDepartment(Department department)
        {
            if (department != null)
            {
                try
                {
                    using (MySqlConnection conn = base.GetConnection())
                    {
                        string sql =
                            "INSERT INTO department (department_name, sells_products) VALUES (@name, @sells);";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@name", department.Name);
                        cmd.Parameters.AddWithValue("@sells", department.SellsProducts);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool UpdateDepartment(int id, string name, bool sells)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                            "UPDATE department SET department_name = @name, sells_products = @sells WHERE department_id = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@sells", sells);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message);
                return false;
            }
        }

        public bool RemoveDepartment(Department department)
        {
            if (department != null)
            {
                try
                {
                    using (MySqlConnection conn = base.GetConnection())
                    {
                        string sql =
                            "DELETE FROM department WHERE department_id = @id;";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@id", department.Id);
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
