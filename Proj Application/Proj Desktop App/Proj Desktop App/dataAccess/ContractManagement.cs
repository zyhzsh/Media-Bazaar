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
    class ContractManagement : DatabaseConnection
    {
        public ContractManagement() : base() { }

        public Contract GetActiveContract(int bsn)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                            "SELECT contract_id, iteration, position_id, department_id, start_date, end_date, salary, fte " +
                            "FROM contract " +
                            "WHERE BSN = @bsn " +
                            "AND start_date <= @today " +
                            "AND end_date >= @today;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    cmd.Parameters.AddWithValue("@today", DateTime.Today.ToString("yyyy-MM-dd"));
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        return InitializeContract(dr);
                    }
                    else { return null; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public Contract[] GetAllContracts(int bsn)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                            "SELECT contract_id, iteration, position_id, department_id, start_date, end_date, salary, fte " +
                            "FROM contract " +
                            "WHERE BSN = @bsn " +
                            "ORDER BY iteration DESC;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    List<Contract> contracts = new List<Contract>();
                    while (dr.Read())
                    {
                        Contract contract = InitializeContract(dr);
                        if (contract != null)
                        {
                            contracts.Add(contract);
                        }
                    }

                    return contracts.ToArray();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int GetLatestContractId(int bsn)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        "SELECT contract_id" +
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

        public bool AddContract(Contract contract)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                        "INSERT INTO contract (BSN, position_id, department_id, " +
                        "start_date, end_date,iteration, salary, fte) " +
                        "VALUES (@bsn, @position_id, @department_id, " +
                        "@start_date, @end_date, @iteration, @salary, @fte);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@position_id", (int)contract.Position);
                    cmd.Parameters.AddWithValue("@department_id", (int)contract.Department);
                    cmd.Parameters.AddWithValue("@start_date", contract.StartDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@end_date", contract.EndDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@iteration", contract.Iteration);
                    cmd.Parameters.AddWithValue("@salary", contract.Salary);
                    cmd.Parameters.AddWithValue("@fte", contract.Fte);
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
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

        private Contract InitializeContract(MySqlDataReader contr)
        {
            try
            {
                Contract contract = new Contract(
                    Convert.ToInt32(contr["contract_id"]),
                    Convert.ToDateTime(contr["start_date"]),
                    Convert.ToDateTime(contr["end_date"]),
                    Convert.ToInt32(contr["iteration"]),
                    (Departments)contr["department_id"],
                    (PositionType)contr["position_id"],
                    Convert.ToDecimal(contr["salary"]),
                    Convert.ToDecimal(contr["fte"]));
                return contract;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
