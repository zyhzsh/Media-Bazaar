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
    public class ProductManagement : DatabaseConnection
    {
        public ProductManagement() : base() { }

        public void AddProduct(Departments belongingDepartment, string productName, string brand, double boughtPrice, double soldPrice)
        {
            
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "INSERT INTO product(department_id, productname, brand, bought_price, sold_price, current_stock)" +
                         "VALUES (@department_id, @productname, @brand, @bought_price, @sold_price, @current_stock)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@department_id", Convert.ToInt32(belongingDepartment));
                    cmd.Parameters.AddWithValue("@productname", productName);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@boughtPrice", boughtPrice);
                    cmd.Parameters.AddWithValue("@soldPrice", soldPrice);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void AddProduct(Departments belongingDepartment, string productName, string brand, double boughtPrice, double soldPrice, string description)
        {
            try
            {
                using(MySqlConnection conn = base.GetConnection())
                {
                    string sql = "INSERT INTO product(department_id, productname, brand, bought_price, sold_price, current_stock, description)" +
                            "VALUES (@department_id, @productname, @brand, @bought_price, @sold_price, @current_stock, @description)";

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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateProduct(int productcode, Departments belongingDepartment, string productName, string brand, double soldPrice, double boughtPrice, string description)
        {
            try
            {
                using(MySqlConnection conn = base.GetConnection())
                {
                    string sql = "UPDATE product SET (department_id = @department_id, productname = @productname, brand = @brand, " +
                         "bought_price = @bought_price, sold_price = @sold_price, current_stock = @current_stock, description = @description) " +
                         "WHERE productcode = @productcode";

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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateProduct(int productcode, Departments belongingDepartment, string productName, string brand, double soldPrice, double boughtPrice)

        {
            try
            {
                using(MySqlConnection conn = base.GetConnection())
                {
                    string sql = "UPDATE product SET (department_id = @department_id, productname = @productname, brand = @brand, " +
                         "bought_price = @bought_price, sold_price = @sold_price, current_stock = @current_stock, description = @description) " +
                         "WHERE productcode = @productcode";

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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        public void RemoveProduct(int productcode)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "DELETE FROM product p" +
                         "WHERE p.productcode = @productcode";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@productcode", productcode);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Product[] GetAllProducts()
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "SELECT p.* FROM product p;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<Product> products = new List<Product>();
                    while (dr.Read())
                    {
                        Product product = InitializeProduct(dr);
                        if(product != null)
                        {
                            products.Add(product);
                        }
                    }

                    return products.ToArray();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public Sale[] GetBestSellingProducts()
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "SELECT p.productcode, p.productname, COUNT(*) AS sales " +
                         "FROM product p INNER JOIN productsales s ON p.productcode = s.product_code " +
                         "GROUP BY p.productcode " +
                         "ORDER BY sales DESC;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<Sale> sales = new List<Sale>();
                    while (dr.Read())
                    {
                        Sale soldProduct = InitializeSale(dr);
                        if(soldProduct != null)
                        {
                            sales.Add(soldProduct);
                        }
                    }
                    return sales.ToArray();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public Sale[] GetBestSellingProducts(DateTime startPeriod)
        {
            
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "SELECT p.productcode, p.productname, COUNT(*) AS sales " +
                         "FROM product p INNER JOIN productsales s ON p.productcode = s.product_code " +
                         "WHERE s.sales_date > @salesPeriod " +
                         "GROUP BY p.productcode " +
                         "ORDER BY sales DESC;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@salesPeriod", startPeriod.ToString("yyyy-MM-dd"));
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<Sale> sales = new List<Sale>();
                    while (dr.Read())
                    {
                        Sale soldProduct = InitializeSale(dr);
                        sales.Add(soldProduct);
                    }
                    return sales.ToArray();
                }
                    
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public Sale[] GetBestSellingProducts(DateTime startPeriod, DateTime endPeriod)
        {
            try
            {
                using (MySqlConnection conn = base.GetConnection())
                {
                    string sql = "SELECT p.productcode, p.productname, p.brand, p.bought_price, p.sold_price, p.department_id, SUM(s.amount) AS sales " +
                                 "FROM product p INNER JOIN productsales s ON p.productcode = s.product_code " +
                                 "WHERE s.sales_date > @startPeriod and s.sales_date < @endPeriod " +
                                 "GROUP BY p.productcode " +
                                 "ORDER BY sales DESC;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    string from = startPeriod.ToString("yyyy-MM-dd");
                    string to = endPeriod.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@startPeriod", from);
                    cmd.Parameters.AddWithValue("@endPeriod", to);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<Sale> sales = new List<Sale>();
                    while (dr.Read())
                    {
                        Sale soldProduct = InitializeSale(dr);
                        sales.Add(soldProduct);
                    }
                    return sales.ToArray();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        private Product InitializeProduct(MySqlDataReader dr)
        {
            try
            {
                Departments department = GetDepartment(Convert.ToInt32(dr["department_id"]));
                string description = "no description";
                if(dr["description"] != DBNull.Value)
                {
                    description = dr["description"].ToString();
                }
                Product product = new Product(
                    Convert.ToInt32(dr["productcode"]),
                    dr["productname"].ToString(),
                    dr["brand"].ToString(),
                    Convert.ToDouble(dr["sold_price"]),
                    Convert.ToDouble(dr["bought_price"]),
                    description,
                    department,
                    Convert.ToInt32(dr["current_stock"])
                    );
                return product;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        private Sale InitializeSale(MySqlDataReader dr)
        {
            try
            {
                Sale sale = new Sale(Convert.ToInt32(dr["productcode"]),
                                Convert.ToString(dr["productname"]),
                                Convert.ToInt32(dr["sales"]));
                return sale;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
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
                default:
                    throw new Exception("Invalid Department id");
            }
        }
    }
}
