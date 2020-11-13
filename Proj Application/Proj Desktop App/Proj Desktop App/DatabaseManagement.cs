﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;

namespace Proj_Desktop_App
{
    class DatabaseManagement
    {
        private MySqlConnection conn;
        public DatabaseManagement()
        {
            try
            {
                conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi443880;Database=dbi443880;Pwd=123456");
            }
            catch (Exception e)
            {
                MessageBox.Show("host"+e.ToString());
            }
            finally
            {

            }
        }

        public Employee[] GetAllEmployees()
        {
            string sql = "SELECT E.*, C.status, C.department_id, C.position_id, C.fte " +
                         "FROM contract C, employee E " +
                         "WHERE C.BSN = E.BSN AND C.start_date = (" +
                                     "SELECT MAX(subC.start_date) " +
                                     "FROM contract subC " +
                                     "WHERE subC.BSN = E.BSN);";
            MySqlCommand cmd = null;
            try
            {
                cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                List<Employee> employees = new List<Employee>();
                while (dr.Read())
                {
                    Departments dep;
                    switch (Convert.ToInt32(dr[13]))
                    {
                        case 1:
                            dep = Departments.floorOne;
                            break;
                        case 2:
                            dep = Departments.floorTwo;
                            break;
                        case 3:
                            dep = Departments.floorThree;
                            break;
                        case 4:
                            dep = Departments.floorFour;
                            break;
                        case 5:
                            dep = Departments.warehouse;
                            break;
                        case 6:
                            dep = Departments.office;
                            break;
                        default:
                            MessageBox.Show("Non existant Department id");
                            return null;
                    }

                    PositionType position;
                    switch (Convert.ToInt32(dr[14]))
                    {
                        case 1:
                            position = PositionType.Sales_Worker;
                            break;
                        case 2:
                            position = PositionType.Sales_Manager;
                            break;
                        case 3:
                            position = PositionType.Depot_Worker;
                            break;
                        case 4:
                            position = PositionType.Depot_Manager;
                            break;
                        case 5:
                            position = PositionType.Administrator;
                            break;
                        default:
                            position = PositionType.Other;
                            break;
                    }

                    Employee newEmp = new Employee(Convert.ToInt32(dr[0]), dr[1].ToString(),
                        dr[2].ToString(), Convert.ToChar(dr[3]), dr[4].ToString(),
                        Convert.ToDateTime(dr[5]), dr[6].ToString(), dr[8].ToString(),
                        dr[7].ToString(), dr[12].ToString(), dep, dr[9].ToString(),
                        Convert.ToDouble(dr[15]), position, position.ToString().Trim());
                    employees.Add(newEmp);
                }

                return employees.ToArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString() + "/n Something wrong");
                return null;
            }
            finally
            {
                conn.Close();
            }
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
        public Product[] GetAllProducts()
        {
            string sql = "SELECT p.productcode, p.productname, p.brand, p.bought_price, p.sold_price, p.department_id " +
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
                    Product newProduct = new Product(Convert.ToInt32(dr[0]), Convert.ToString(dr[1]), Convert.ToString(dr[2]), Convert.ToDouble(dr[4]), Convert.ToDouble(dr[3]), belongingDepartment);
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
            return null;
        }

        public RestockRequest[] GetPendingRestockRequests()
        {
            string sql = "SELECT ID, req.productcode, p.productname, requester_bsn, restock_amount, requester_desc " +
                         "FROM restockrequest req, product p " +
                         "WHERE req.status = 'PENDING' AND p.productcode = req.productcode;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            MySqlDataReader dr = cmd.ExecuteReader();

            List<RestockRequest> requests = new List<RestockRequest>();
            while (dr.Read())
            {
                RestockRequest restocky = new RestockRequest(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), Convert.ToString(dr[2]), Convert.ToInt32(dr[3]), Convert.ToInt32(dr[4]), Convert.ToString(dr[5]));
                requests.Add(restocky);
            }

            return null;
        }

        public void CreateRestockRequest(int productcode, int requester_bsn, int restock_amount, string requester_desc)
        {
            try
            {
                string sql =
                    "INSERT INTO restockrequest(productcode, requester_bsn, restock_amount, requester_desc, status) " +
                    "VALUES(@productcode, @requester_bsn, @restock_amount, @requester_desc, @status);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                
                cmd.Parameters.AddWithValue("@productcode", productcode);
                cmd.Parameters.AddWithValue("@requester_bsn", requester_bsn);
                cmd.Parameters.AddWithValue("@restock_amount", restock_amount);
                cmd.Parameters.AddWithValue("@requester_desc", requester_desc);
                cmd.Parameters.AddWithValue("@status", "pending");

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
                             "SET judge_bsn = @judge_bsn, description = @judge_desc, status = 'ACCEPTED' " +
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
                Console.WriteLine(e);
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
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
        }

        public void RestockProduct(int restock_id, int product_id, int restocker_BSN, int restockedAmount, string report)
        {

            // REQUEST UPDATE
            try
            {
                string sql = "UPDATE restockrequest " +
                             "SET restocker_bsn = @restocker_bsn, restock_amount = @restock_amount, worker_report = @worker, status = 'COMPLETED' " +
                             "WHERE ID = @restock_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@worker_report", report);
                cmd.Parameters.AddWithValue("@restock_amount", restockedAmount);
                cmd.Parameters.AddWithValue("@restocker_BSN", restocker_BSN);
                cmd.Parameters.AddWithValue("@restock_id", restock_id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
            /// REQUEST UPDATE

            // PRODUCT RESTOCK

            try
            {
                string sql = "UPDATE product " +
                             "SET current_stock = @stock" +
                             "WHERE ID = @product_id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int stock = GetProductStock(product_id) + restockedAmount;
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@restock_id", restock_id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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

        public Sale[] GetBestSellingProducts(DateTime period)
        {
            string sql = "SELECT p.productcode, p.productname, COUNT(*) AS sales " +
                         "FROM product p INNER JOIN productsales s ON p.productcode = s.product_code " +
                         "WHERE s.sales_date > @salesPeriod " +
                         "GROUP BY p.productcode " +
                         "ORDER BY sales DESC;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@salesPeriod", period);
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
                cmd.Parameters.AddWithValue("@startPeriod", startPeriod);
                cmd.Parameters.AddWithValue("@endPeriod", endPeriod);
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