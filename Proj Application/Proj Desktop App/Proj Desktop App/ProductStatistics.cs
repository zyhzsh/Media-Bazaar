﻿using Proj_Desktop_App.dataAccess;
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
            ProcuctManagement dtbMan = new ProcuctManagement();
            dateTimeSalesTo.Value = DateTime.Today;
            Sale[] sales = dtbMan.GetBestSellingProducts();
            lbBestSoldProducts.Items.Clear();
            foreach(Sale s in sales)
            {
                lbBestSoldProducts.Items.Add(s);
            }
        }

        private void btnProductStatFilter_Click(object sender, EventArgs e)
        {
            ProcuctManagement dtbMan = new ProcuctManagement();
            Sale[] sales = dtbMan.GetBestSellingProducts(dateTimeSalesFrom.Value, dateTimeSalesTo.Value);
            lbBestSoldProducts.Items.Clear();
            foreach(Sale s in sales)
            {
                lbBestSoldProducts.Items.Add(s);
            }
        }
    }
}
