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
    class ProcuctManagement : DatabaseConnection
    {
        private MySqlConnection conn;
        public ProcuctManagement() : base()
        {
            conn = base.GetConnection();
        }

        public void AddProduct(Departments belongingDepartment, string productName, string brand, double boughtPrice, double soldPrice)
        {
            string sql = "INSERT INTO product(department_id, productname, brand, bought_price, sold_price, current_stock)" +
                         "VALUES (@department_id, @productname, @brand, @bought_price, @sold_price, @current_stock)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department_id", Convert.ToInt32(belongingDepartment));
                cmd.Parameters.AddWithValue("@productname", productName);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@boughtPrice", boughtPrice);
                cmd.Parameters.AddWithValue("@soldPrice", soldPrice);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void AddProduct(Departments belongingDepartment, string productName, string brand, double boughtPrice, double soldPrice, string description)
        {
            string sql = "INSERT INTO product(department_id, productname, brand, bought_price, sold_price, current_stock, description)" +
                         "VALUES (@department_id, @productname, @brand, @bought_price, @sold_price, @current_stock, @description)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department_id", Convert.ToInt32(belongingDepartment));
                cmd.Parameters.AddWithValue("@productname", productName);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@boughtPrice", boughtPrice);
                cmd.Parameters.AddWithValue("@soldPrice", soldPrice);
                cmd.Parameters.AddWithValue("@description", description);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateProduct(int productcode, Departments belongingDepartment, string productName, string brand, double soldPrice, double boughtPrice, string description)
        {
            string sql = "UPDATE product SET (department_id = @department_id, productname = @productname, brand = @brand, " +
                         "bought_price = @bought_price, sold_price = @sold_price, current_stock = @current_stock, description = @description) " +
                         "WHERE productcode = @productcode";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department_id", Convert.ToInt32(belongingDepartment));
                cmd.Parameters.AddWithValue("@productname", productName);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@boughtPrice", boughtPrice);
                cmd.Parameters.AddWithValue("@soldPrice", soldPrice);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@productcode", productcode);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateProduct(int productcode, Departments belongingDepartment, string productName, string brand, double soldPrice, double boughtPrice)

        {
            string sql = "UPDATE product SET (department_id = @department_id, productname = @productname, brand = @brand, " +
                         "bought_price = @bought_price, sold_price = @sold_price, current_stock = @current_stock, description = @description) " +
                         "WHERE productcode = @productcode";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department_id", Convert.ToInt32(belongingDepartment));
                cmd.Parameters.AddWithValue("@productname", productName);
                cmd.Parameters.AddWithValue("@brand", brand);
                cmd.Parameters.AddWithValue("@boughtPrice", boughtPrice);
                cmd.Parameters.AddWithValue("@soldPrice", soldPrice);
                cmd.Parameters.AddWithValue("@productcode", productcode);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public void RemoveProduct(int productcode)
        {
            string sql = "DELETE FROM product p" +
                         "WHERE p.productcode = @productcode";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@productcode", productcode);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public Product[] GetAllProducts()
        {
            string sql = "SELECT p.productcode, p.productname, p.brand, p.bought_price, p.sold_price, p.department_id, p.current_stock " +
                         "FROM product p;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                List<Product> products = new List<Product>();
                while (dr.Read())
                {
                    Departments belongingDepartment = Departments.office;
                    switch (dr[5])
                    {
                        case 1:
                            belongingDepartment = Departments.floorOne;
                            break;
                        case 2:
                            belongingDepartment = Departments.floorTwo;
                            break;
                        case 3:
                            belongingDepartment = Departments.floorThree;
                            break;
                        case 4:
                            belongingDepartment = Departments.floorFour;
                            break;
                        default:
                            belongingDepartment = Departments.office;
                            break;


                    }
                    Product newProduct = new Product(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToDouble(dr[4]), Convert.ToDouble(dr[3]), belongingDepartment, Convert.ToInt32(dr[6]));
                    products.Add(newProduct);
                }
                return products.ToArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message+"AAAAA");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        private int GetProductStock(int productcode)
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public RestockRequest[] GetAllRestockRequests()
        {
            //leave this for now
            string sql = "SELECT ID, req.productcode, p.productname, requester_bsn, restock_amount, requester_desc " +
                         "FROM restockrequest req INNER JOIN product p ON req.productcode = p.productcode;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                List<RestockRequest> requests = new List<RestockRequest>();
                while (dr.Read())
                {
                    RestockRequest restocky = new RestockRequest(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), Convert.ToString(dr[2]), Convert.ToInt32(dr[3]), 0, Convert.ToInt32(dr[4]), Convert.ToString(dr[5]), null);
                    requests.Add(restocky);
                }

                return requests.ToArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public RestockRequest[] GetPendingRestockRequests()
        {
            string sql = "SELECT ID, req.productcode, p.productname, requester_bsn, restock_amount, requester_desc " +
                         "FROM restockrequest req, product p " +
                         "WHERE req.status = 'PENDING' AND p.productcode = req.productcode;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                List<RestockRequest> requests = new List<RestockRequest>();
                while (dr.Read())
                {
                    RestockRequest restocky = new RestockRequest(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), Convert.ToString(dr[2]),
                        Convert.ToInt32(dr[3]), 0, Convert.ToInt32(dr[4]), Convert.ToString(dr[5]), null);
                    requests.Add(restocky);
                }

                return requests.ToArray();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public RestockRequest[] GetAcceptedRestockRequests()
        {
            string sql = "SELECT ID, req.productcode, p.productname, requester_bsn, judge_bsn, restock_amount, requester_desc, judge_desc " +
                         "FROM restockrequest req, product p " +
                         "WHERE req.status = 'ACCEPTED' AND p.productcode = req.productcode;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                List<RestockRequest> requests = new List<RestockRequest>();
                while (dr.Read())
                {
                    RestockRequest restocky = new RestockRequest(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]),Convert.ToString(dr[2]),
                        Convert.ToInt32(dr[3]), Convert.ToInt32(dr[4]), Convert.ToInt32(dr[5]), Convert.ToString(dr[6]), Convert.ToString(dr[7]));
                    requests.Add(restocky);
                }

                return requests.ToArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public void CreateRestockRequest(RestockRequest req)
        {
            try
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
            catch(Exception e)
            {
                MessageBox.Show(e.ToString() + "some fields have not been filled in properly");
            }
            finally
            {
                conn.Close();
            }
        }

        public void AcceptRestockRequest(int restock_id, int judge_bsn, string judge_desc)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeclineRestockRequest(int restock_id, int judge_bsn, string judge_desc)
        {
            try
            {
                string sql = "UPDATE restockrequest " +
                             "SET judge_bsn = @judge_bsn, description = @judge_desc, status = 'DECLINED' " +
                             "WHERE ID = @restock_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@judge_bsn", judge_bsn);
                cmd.Parameters.AddWithValue("@judge_desc", judge_desc);
                cmd.Parameters.AddWithValue("@restock_id", restock_id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void RestockProduct(RestockRequest req, int workerBsn,int restockAmount, string worker_report)
        {

            // REQUEST UPDATE
            try
            {
                string sql = "UPDATE restockrequest " +
                             "SET restocker_bsn = @restocker_BSN, restock_amount = @restock_amount, worker_report = @worker_report, status = 'COMPLETED' " +
                             "WHERE ID = @restock_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@worker_report", worker_report);
                cmd.Parameters.AddWithValue("@restock_amount", restockAmount);
                cmd.Parameters.AddWithValue("@restocker_BSN", workerBsn);
                cmd.Parameters.AddWithValue("@restock_id", req.restockID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            /// REQUEST UPDATE

            UpdateProductStock(req, restockAmount);
        }

        private void UpdateProductStock(RestockRequest req, int restockAmount)
        {
            // PRODUCT RESTOCK

            try
            {
                string sql = "UPDATE product " +
                             "SET current_stock = @stock" +
                             "WHERE ID = @product_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int stock = GetProductStock(req.productCode) + restockAmount;
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@product_id", req.productCode);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            ///PRODUCT RESTOCK
        }

        public Sale[] GetBestSellingProducts()
        {
            string sql = "SELECT p.productcode, p.productname, COUNT(*) AS sales " +
                         "FROM product p INNER JOIN productsales s ON p.productcode = s.product_code " +
                         "GROUP BY p.productcode " +
                         "ORDER BY sales DESC;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                List<Sale> sales = new List<Sale>();
                while (dr.Read())
                {
                    
                    Sale soldProduct = new Sale(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]));
                    sales.Add(soldProduct);
                }
                return sales.ToArray();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Sale[] GetBestSellingProducts(DateTime startPeriod)
        {
            string sql = "SELECT p.productcode, p.productname, COUNT(*) AS sales " +
                         "FROM product p INNER JOIN productsales s ON p.productcode = s.product_code " +
                         "WHERE s.sales_date > @salesPeriod " +
                         "GROUP BY p.productcode " +
                         "ORDER BY sales DESC;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@salesPeriod", startPeriod.ToString("yyyy-MM-dd"));
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                List<Sale> sales = new List<Sale>();
                while (dr.Read())
                {
                    Sale soldProduct = new Sale(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]));
                    sales.Add(soldProduct);
                }
                return sales.ToArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Sale[] GetBestSellingProducts(DateTime startPeriod, DateTime endPeriod)
        {
            string sql = "SELECT p.productcode, p.productname, p.brand, p.bought_price, p.sold_price, p.department_id, COUNT(*) AS sales " +
                         "FROM product p INNER JOIN productsales s ON p.productcode = s.product_code " +
                         "WHERE s.sales_date > @startPeriod and s.sales_date < @endPeriod " +
                         "GROUP BY p.productcode " +
                         "ORDER BY sales DESC;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                string from = startPeriod.ToString("yyyy-MM-dd");
                string to = startPeriod.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@startPeriod", from);
                cmd.Parameters.AddWithValue("@endPeriod", to);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                List<Sale> sales = new List<Sale>();
                while (dr.Read())
                {
                    Sale soldProduct = new Sale(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToInt32(dr[2]));
                    sales.Add(soldProduct);
                }
                return sales.ToArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
