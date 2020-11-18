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
                            "SELECT iteration, position_id, department_id, start_date, end_date, salary, fte " +
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
                        return new Contract(
                            Convert.ToDateTime(dr["start_date"]),
                            Convert.ToDateTime(dr["end_date"]),
                            Convert.ToInt32(dr["iteration"]),
                            (Departments)dr["department_id"],
                            (PositionType)dr["position_id"],
                            Convert.ToDecimal(dr["salary"]),
                            Convert.ToDecimal(dr["fte"]));
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
                            "SELECT iteration, position_id, department_id, start_date, end_date, salary, fte " +
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
                        Contract contract = new Contract(
                            Convert.ToDateTime(dr["start_date"]),
                            Convert.ToDateTime(dr["end_date"]),
                            Convert.ToInt32(dr["iteration"]),
                            (Departments)dr["department_id"],
                            (PositionType)dr["position_id"],
                            Convert.ToDecimal(dr["salary"]),
                            Convert.ToDecimal(dr["fte"]));
                        contracts.Add(contract);
                    }

                    return contracts.ToArray();
                }
            }
            catch (Exception)
            {
                return null;
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

        public bool AddContract()
        {
            throw new NotImplementedException();
        }

        public bool Promote()
        {
            throw new NotImplementedException();
        }

        public bool TerminateContract()
        {
            throw new NotImplementedException();
        }
    }
}
