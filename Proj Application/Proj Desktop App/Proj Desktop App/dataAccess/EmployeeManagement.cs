﻿using System;
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
                        "FROM employee " +
                        "WHERE BSN = @bsn;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    conn.Open();
                    MySqlDataReader empl = cmd.ExecuteReader();
                    if (empl.Read())
                    {
                        return InitializeEmployee(empl);
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
                        "SELECT * FROM employee e;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    MySqlDataReader empl = cmd.ExecuteReader();
                    List<Employee> employees = new List<Employee>();
                    while (empl.Read())
                    {
                        Employee employee = InitializeEmployee(empl);
                        if (employee != null)
                        {
                            employees.Add(employee);
                        }
                    }

                    return employees.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                            "@email, @username, @password); ";
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

        public bool UpdateEmployee(int bsn, string firstName, string lastName, char gender, string languages,
            string certificates, string phoneNumber, string address, string contactEmail)
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
                    cmd.Parameters.AddWithValue("@first_name", firstName);
                    cmd.Parameters.AddWithValue("@last_name", lastName);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@languages", languages);
                    cmd.Parameters.AddWithValue("@certificates", certificates);
                    cmd.Parameters.AddWithValue("@phone", phoneNumber);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@contact_email", contactEmail);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
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

        private Employee InitializeEmployee(MySqlDataReader empl)
        {
            try
            {
                Employee employee = new Employee(
                    Convert.ToInt32(empl["BSN"]),
                    empl["first_name"].ToString(),
                    empl["last_name"].ToString(),
                    Convert.ToChar(empl["gender"]),
                    Convert.ToDateTime(empl["date_birth"]),
                    empl["languages"].ToString(),
                    empl["certificates"].ToString(),
                    empl["phone"].ToString(),
                    empl["address"].ToString(),
                    empl["contact_email"].ToString());
                return employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
