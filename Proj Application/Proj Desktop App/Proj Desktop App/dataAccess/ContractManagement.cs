using MySql.Data.MySqlClient;
using System;

namespace Proj_Desktop_App.dataAccess
{
    class ContractManagement : DatabaseConnection
    {
        public ContractManagement() : base() { }

        public int GetLatestContractId(int bsn)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        "SELECT contract_id " +
                        "FROM contract " +
                        "WHERE BSN = @bsn " +
                        "ORDER BY start_date DESC " +
                        "LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        return Convert.ToInt32(dr["contract_id"]);
                    }
                    else { return -1; }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public decimal GetStartingSalary(PositionType positionType)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        "SELECT starting_salary " +
                        "FROM position " +
                        "WHERE position_id = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", (int)positionType);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        return Convert.ToDecimal(dr["starting_salary"]);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int AddContract(int bsn, Contract contract)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        "INSERT INTO contract (BSN, position_id, department_id, " +
                        "start_date, end_date,iteration, salary, fte) " +
                        "VALUES (@bsn, @position_id, @department_id, " +
                        "@start_date, @end_date, @iteration, @salary, @fte); " +
                        "SELECT contract_id FROM contract " +
                        "WHERE BSN=@bsn " +
                        "ORDER BY start_date DESC " +
                        "LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    cmd.Parameters.AddWithValue("@position_id", (int)contract.Position);
                    cmd.Parameters.AddWithValue("@department_id", contract.Department.Id);
                    cmd.Parameters.AddWithValue("@start_date", contract.StartDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@end_date", contract.EndDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@iteration", contract.Iteration);
                    cmd.Parameters.AddWithValue("@salary", contract.Salary);
                    cmd.Parameters.AddWithValue("@fte", contract.Fte);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        return Convert.ToInt32(dr["contract_id"]);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public bool Promote(int id, decimal newSalary)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        "UPDATE contract " +
                        "SET salary = @salary " +
                        "WHERE contract_id = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@salary", newSalary);
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
            catch (Exception)
            {
                return false;
            }
        }

        public bool TerminateContract(int id, DateTime endDate)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        "UPDATE contract " +
                        "SET end_date = @end_date " +
                        "WHERE contract_id = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@end_date", endDate.ToString("yyyy-MM-dd"));
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
            catch (Exception)
            {
                return false;
            }
        }
    }
}
