using MySql.Data.Types;
using Proj_Desktop_App.dataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public partial class ProductStatistics : Form
    {
        private ProductManagement dtbMan;

        public ProductStatistics(DepartmentStorage departments)
        {
            InitializeComponent();
            dtbMan = new ProductManagement(departments);
            lbBestSoldProducts.Items.Clear();

            dateTimeSalesFrom.Value = DateTime.Today.AddDays(-30);
            Sale[] sales = dtbMan.GetBestSellingProducts();
            foreach (Sale s in sales)
            {
                lbBestSoldProducts.Items.Add(s);
            }
        }

        private void btnProductStatFilter_Click(object sender, EventArgs e)
        {
            Sale[] sales = dtbMan.GetBestSellingProducts(dateTimeSalesFrom.Value, dateTimeSalesTo.Value);
            lbBestSoldProducts.Items.Clear();
            foreach(Sale s in sales)
            {
                lbBestSoldProducts.Items.Add(s);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dateTimeSalesTo.Value = DateTime.Today;
            dateTimeSalesFrom.Value = DateTime.Today;
            dateTimeSalesFrom.Value.AddDays(-30);
            Sale[] sales = dtbMan.GetBestSellingProducts();
            lbBestSoldProducts.Items.Clear();
            foreach (Sale s in sales)
            {
                lbBestSoldProducts.Items.Add(s);
            }
        }
    }
}
