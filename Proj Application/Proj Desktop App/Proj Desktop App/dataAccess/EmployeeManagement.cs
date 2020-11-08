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
    class EmployeeManagement : DatabaseConnection
    {
        public EmployeeManagement() : base() { }

        public Employee GetEmployee(int bsn)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        "SELECT * " +
                        "FROM employee e " +
                        "INNER JOIN contract c " +
                        "ON e.BSN = c.BSN " +
                        "WHERE e.BSN = @bsn " +
                        "AND c.status = TRUE" +
                        "ORDER BY start_date DECS" +
                        "LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        return InitializeEmployee(dr);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

        }
        
        public Employee[] GetAllEmployees()
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        "SELECT * " +
                        "FROM employee e " +
                        "INNER JOIN contract c " +
                        "ON e.BSN = c.BSN " +
                        "WHERE c.status = TRUE" +
                        "ORDER BY start_date DECS;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<Employee> employees = new List<Employee>();
                    while (dr.Read())
                    {
                        Employee employee = InitializeEmployee(dr);
                        if (employee != null)
                        {
                            employees.Add(employee);
                        }
                    }

                    return employees.ToArray();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool AddEmployee(Employee employee)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        // TO DO:
                        "INSERT INTO user (BSN, first_name, last_name, ... ) " +
                        "VALUES(@bsn, @first_name, @last_name, ... )";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = 
                        "UPDATE employee " +
                        "SET first_name = @first_name, " +
                        "last_name = @last_name, " +
                        "gender = @gender, " +
                        "languages = @languages, " +
                        "certificates = @certificates " +
                        "phone = @phone " +
                        "address = @address " +
                        "contact_email = @contact_email " +
                        "WHERE BSN = @bsn;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@first_name", employee.firstName);
                    cmd.Parameters.AddWithValue("@last_name", employee.lastName);
                    cmd.Parameters.AddWithValue("@gender", employee.gender);
                    cmd.Parameters.AddWithValue("@languages", employee.languages);
                    cmd.Parameters.AddWithValue("@certificates", employee.certificates);
                    cmd.Parameters.AddWithValue("@phone", employee.phoneNumber);
                    cmd.Parameters.AddWithValue("@address", employee.address);
                    cmd.Parameters.AddWithValue("@contact_email", employee.contactEmail);
                    cmd.Parameters.AddWithValue("@bsn", employee.GetBSN());
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private Employee InitializeEmployee(MySqlDataReader dr)
        {
            try
            {
                PositionType position = GetPosition(Convert.ToInt32(dr["position_id"]));
                Departments department = GetDepartment(Convert.ToInt32(dr["department_id"]));
                Employee employee = new Employee(
                    Convert.ToInt32(dr["BSN"]),
                    dr["first_name"].ToString(),
                    dr["last_name"].ToString(),
                    Convert.ToChar(dr["gender"]),
                    Convert.ToDateTime(dr["date_birth"]),
                    dr["languages"].ToString(),
                    dr["certificates"].ToString(),
                    dr["phone"].ToString(),
                    dr["address"].ToString(),
                    dr["contact_email"].ToString(),
                    Convert.ToDateTime(dr["start_date"]),
                    Convert.ToDateTime(dr["end_date"]),
                    position,
                    department,
                    Convert.ToDecimal(dr["fte"])
                    );
                return employee;
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        private PositionType GetPosition(int positionId)
        {
            switch (positionId)
            {
                case 1:
                    return PositionType.Sales_Worker;
                case 2:
                    return PositionType.Sales_Manager;
                case 3:
                    return PositionType.Depot_Worker;
                case 4:
                    return PositionType.Depot_Manager;
                case 5:
                    return PositionType.Administrator;
                default:
                    return PositionType.Other;
            }
        }

        private Departments GetDepartment(int departmentId)
        {
            switch (departmentId)
            {
                case 1:
                    return Departments.floorOne;
                case 2:
                    return Departments.floorTwo;
                case 3:
                    return Departments.floorThree;
                case 4:
                    return Departments.floorFour;
                case 5:
                    return Departments.warehouse;
                case 6:
                    return Departments.office;
                default:
                    throw new Exception("Depatemnt id doesn't exist");
            }
        }
    }
}
