using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public partial class ProductStatistics : Form
    {
        private static List<Product> currentProducts;
        public ProductStatistics(Product[] products)
        {
            InitializeComponent();
            currentProducts = new List<Product>();
            foreach (Product p in products)
            {
                currentProducts.Add(p);
                lbProductListStatistics.Items.Add(p);
            }

        }

        private void btnRequestRestock_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            switch (cbProductSearchMethod.SelectedItem.ToString().Trim())
            {
                case "Product code":
                    if (tbProductSearchAttribute.Text.Length > 0)
                    {
                        for (int i = 0; i < lbProductListStatistics.Items.Count; i++)
                        {
                            if (((Product)lbProductListStatistics.Items[i]).ProductCode != Convert.ToInt32(tbProductSearchAttribute.Text))
                            {
                                lbProductListStatistics.Items.Remove(lbProductListStatistics.Items[i]);
                            }
                        }
                        lbProductListStatistics.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("textbox is empty");
                    }
                    break;
                case "Product name":
                    if (tbProductSearchAttribute.Text.Length > 0)
                    {
                        Regex rx = new Regex(@"\s+"+tbProductSearchAttribute.Text+"\\s+");
                        foreach (Product product in lbProductListStatistics.Items)
                        {
                            if (!rx.Match(product.ProductName).Success)
                            {
                                lbProductListStatistics.Items.Remove(product);
                            }
                        }
                        lbProductListStatistics.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("textbox is empty");
                    }
                    break;

            }
        }
    }
}
