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
        public ProductStatistics()
        {
            InitializeComponent();
            ProductManagement dtbMan = new ProductManagement();
            lbBestSoldProducts.Items.Clear();
            dateTimeSalesFrom.Value.AddDays(-30);
            Sale[] sales = dtbMan.GetBestSellingProducts(dateTimeSalesFrom.Value);
            foreach (Sale s in sales)
            {
                lbBestSoldProducts.Items.Add(s);
            }
            MessageBox.Show((DateTime.Today.AddDays(-30)).ToString());
        }

        private void btnProductStatFilter_Click(object sender, EventArgs e)
        {
            ProductManagement dtbMan = new ProductManagement();
            Sale[] sales = dtbMan.GetBestSellingProducts(dateTimeSalesFrom.Value, dateTimeSalesTo.Value);
            lbBestSoldProducts.Items.Clear();
            foreach(Sale s in sales)
            {
                lbBestSoldProducts.Items.Add(s);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ProductManagement dtbMan = new ProductManagement();
            dateTimeSalesTo.Value = DateTime.Today;
            dateTimeSalesFrom.Value = DateTime.Today;
            dateTimeSalesFrom.Value.AddDays(-30);
            Sale[] sales = dtbMan.GetBestSellingProducts(dateTimeSalesFrom.Value, dateTimeSalesTo.Value);
            lbBestSoldProducts.Items.Clear();
            foreach (Sale s in sales)
            {
                lbBestSoldProducts.Items.Add(s);
            }
        }
    }
}
