using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Renci.SshNet.Messages;

namespace Proj_Desktop_App.dataAccess
{
    class RestockRequestManagement : DatabaseConnection
    {
        public RestockRequestManagement() : base() { }

        private int GetProductStock(int productcode)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "SELECT current_stock " +
                                  "FROM product " +
                                  "WHERE productcode = @productcode;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@productcode", productcode);
                    int stock = Convert.ToInt32(cmd.ExecuteScalar());
                    return stock;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return -1;
            }
        }

        public RestockRequest[] GetAllRestockRequests()
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "SELECT * " +
                         "FROM restockrequest req INNER JOIN product p ON req.productcode = p.productcode;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<RestockRequest> requests = new List<RestockRequest>();
                    while (dr.Read())
                    {
                        RestockRequest request = InitializeRestockRequest(dr);
                        if (request != null)
                        {
                            requests.Add(request);
                        }
                    }
                    return requests.ToArray();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        public void CreateRestockRequest(RestockRequest req)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql =
                    "INSERT INTO restockrequest(productcode, requester_bsn, restock_amount, requester_desc, status) " +
                    "VALUES(@productcode, @requester_bsn, @restock_amount, @requester_desc, @status);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@productcode", req.productCode);
                    cmd.Parameters.AddWithValue("@requester_bsn", req.requesterBsn);
                    cmd.Parameters.AddWithValue("@restock_amount", req.restockAmount);
                    cmd.Parameters.AddWithValue("@requester_desc", req.requester_desc);
                    cmd.Parameters.AddWithValue("@status", "PENDING");

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void AcceptRestockRequest(int restock_id, int judge_bsn, string judge_desc)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "UPDATE restockrequest " +
                             "SET judge_bsn = @judge_bsn, judge_desc = @judge_desc, status = 'ACCEPTED' " +
                             "WHERE ID = @restock_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@judge_bsn", judge_bsn);
                    cmd.Parameters.AddWithValue("@judge_desc", judge_desc);
                    cmd.Parameters.AddWithValue("@restock_id", restock_id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void DeclineRestockRequest(int restock_id, int judge_bsn, string judge_desc)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "UPDATE restockrequest " +
                             "SET judge_bsn = @judge_bsn, judge_desc = @judge_desc, status = 'DECLINED' " +
                             "WHERE ID = @restock_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@judge_bsn", judge_bsn);
                    cmd.Parameters.AddWithValue("@judge_desc", judge_desc);
                    cmd.Parameters.AddWithValue("@restock_id", restock_id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void RestockProduct(RestockRequest req, int workerBsn, int restockAmount, string worker_report)
        {
            ///REQUEST UPDATE
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "UPDATE restockrequest " +
                             "SET restocker_bsn = @restocker_BSN, worker_report = @worker_report, status = 'COMPLETED' " +
                             "WHERE ID = @restock_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@worker_report", worker_report);
                    cmd.Parameters.AddWithValue("@restocker_BSN", workerBsn);
                    cmd.Parameters.AddWithValue("@restock_id", req.restockID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            /// REQUEST UPDATE

            UpdateProductStock(req.productCode, restockAmount);
        }

        private void UpdateProductStock(int productCode, int restockAmount)
        {
            // PRODUCT RESTOCK
            int stock = GetProductStock(productCode) + restockAmount;
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "UPDATE product " +
                             "SET current_stock = @stock " +
                             "WHERE productcode = @product_id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@product_id", productCode);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            ///PRODUCT RESTOCK
        }

        private RestockRequest InitializeRestockRequest(MySqlDataReader dr)
        {
            try
            {
                bool judged = dr["judge_bsn"] != DBNull.Value;
                bool completed = judged && dr["restocker_bsn"] != DBNull.Value;

                string worker_report = "no report";
                string judge_desc = "no reasoning provided";
                string requester_desc = "no request message";
                //default values if null

                if (dr["worker_report"] != DBNull.Value)
                {
                    worker_report = dr["worker_report"].ToString();
                }
                if (dr["judge_desc"] != DBNull.Value)
                {
                    judge_desc = dr["judge_desc"].ToString();
                }
                if (dr["requester_desc"] != DBNull.Value)
                {
                    requester_desc = dr["judge_desc"].ToString();
                }
                RestockRequest request;

                if (judged && completed)
                {
                    request = new RestockRequest(Convert.ToInt32(dr["ID"]),
                                                            Convert.ToInt32(dr["productcode"]),
                                                            dr["productname"].ToString(),
                                                            (Departments)dr["department_id"],
                                                            Convert.ToInt32(dr["requester_bsn"]),
                                                            Convert.ToInt32(dr["judge_bsn"]),
                                                            Convert.ToInt32(dr["restocker_bsn"]),
                                                            Convert.ToInt32(dr["restock_amount"]),
                                                            requester_desc,
                                                            judge_desc,
                                                            worker_report,
                                                            dr["status"].ToString());
                }
                else if (judged && !completed)
                {
                    request = new RestockRequest(Convert.ToInt32(dr["ID"]),
                                                            Convert.ToInt32(dr["productcode"]),
                                                            dr["productname"].ToString(),
                                                            (Departments)(dr["department_id"]),
                                                            Convert.ToInt32(dr["requester_bsn"]),
                                                            Convert.ToInt32(dr["judge_bsn"]),
                                                            Convert.ToInt32(dr["restock_amount"]),
                                                            requester_desc,
                                                            judge_desc,
                                                            dr["status"].ToString());
                }
                else
                {
                    request = new RestockRequest(Convert.ToInt32(dr["ID"]),
                                                            Convert.ToInt32(dr["productcode"]),
                                                            dr["productname"].ToString(),
                                                            (Departments)(dr["department_id"]),
                                                            Convert.ToInt32(dr["requester_bsn"]),
                                                            Convert.ToInt32(dr["restock_amount"]),
                                                            requester_desc,
                                                            dr["status"].ToString());
                }
                
                return request;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
