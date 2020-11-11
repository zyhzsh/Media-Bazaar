using System;
using System.Collections.Generic;
using System.Globalization;
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
                        "AND c.is_active = TRUE " +
                        "ORDER BY start_date DESCs" +
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
                        "SELECT * FROM employee e " +
                        "INNER JOIN contract c " +
                        "ON e.BSN = c.BSN " +
                        "WHERE c.is_active = 1 " +
                        "GROUP BY e.BSN; ";
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
            if (employee != null)
            {
                try
                {
                    using (MySqlConnection conn = base.GetConnection())
                    {
                        string sql =
                            "INSERT INTO employee (BSN, first_name, last_name, " +
                            "gender, phone, date_birth, address, languages, certificates, " +
                            "contact_email, username, password) " +
                            "VALUES(@bsn, @first_name, @last_name, " +
                            "@gender, @phone, @date_birth, @address, @languages, @certificates, " +
                            "@email, @username, @password);";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@bsn", employee.GetBSN());
                        cmd.Parameters.AddWithValue("@first_name", employee.firstName);
                        cmd.Parameters.AddWithValue("@last_name", employee.lastName);
                        cmd.Parameters.AddWithValue("@gender", employee.gender);
                        cmd.Parameters.AddWithValue("@phone", employee.phoneNumber);
                        cmd.Parameters.AddWithValue("@date_birth", employee.birthDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@address", employee.address);
                        cmd.Parameters.AddWithValue("@languages", employee.languages);
                        cmd.Parameters.AddWithValue("@certificates", employee.certificates);
                        cmd.Parameters.AddWithValue("@email", employee.contactEmail);
                        cmd.Parameters.AddWithValue("@username", GenerateUsername(employee));
                        cmd.Parameters.AddWithValue("@password", GeneratePassword(8));
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
                        "certificates = @certificates, " +
                        "phone = @phone, " +
                        "address = @address, " +
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
            catch (Exception)
            {
                return false;
            }
        }

        private string GenerateUsername(Employee employee)
        {
            if (employee != null)
            {
                // First letter of first name
                string username = employee.firstName.Substring(0, 1).ToLower();
                // Last name
                username += "." + employee.lastName.ToLower();
                return username;
            }
            else
            {
                return null;
            }
        }

        private string GeneratePassword(int characters)
        {
            Random random = new Random();
            string password = "";
            for (int i = 0; i < characters; i++)
            {
                int charInt;
                do
                {
                    charInt = random.Next(48, 123);
                }
                // Numbers, capital and lower case letters
                while ((charInt > 57 && charInt < 65) || (charInt > 90 && charInt < 97));
                password += Convert.ToChar(charInt);
            }
            return password;
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
                    dr.GetDateTime("start_date"),
                    dr.GetDateTime("end_date"),
                    position,
                    department,
                    Convert.ToDecimal(dr["fte"])
                    );
                return employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
