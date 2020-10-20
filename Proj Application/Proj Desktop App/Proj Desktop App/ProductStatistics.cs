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
        private Store mediaBazaar;
        public ProductStatistics(Store form1MediaBazaar)
        {
            InitializeComponent();
            mediaBazaar = form1MediaBazaar;
            foreach (Product p in mediaBazaar.Products)
            {
                lbProductListStatistics.Items.Add(p);
            }

            foreach (RestockRequest request in mediaBazaar.GetRestockRequests)
            {
                lbPendingRestocks.Items.Add(request);
            }
        }

        private void ReloadProducts()
        {
            lbProductListStatistics.Items.Clear();
            foreach (Product p in mediaBazaar.Products)
            {
                lbProductListStatistics.Items.Add(p);
            }
        }

        private void ReloadProductsByFloors()
        {
            ReloadProducts();
            switch (cbProductDepartmentSelector.SelectedItem.ToString().Trim())
            {
                case "Floor One":
                    for (int i = lbProductListStatistics.Items.Count - 1; i >= 0; i--)
                    {
                        if (((Product)lbProductListStatistics.Items[i]).belongingDepartment != Departments.floorOne)
                        {
                            lbProductListStatistics.Items.RemoveAt(i);
                        }
                    }
                    break;
                case "Floor Two":
                    for (int i = lbProductListStatistics.Items.Count - 1; i >= 0; i--)
                    {
                        if (((Product)lbProductListStatistics.Items[i]).belongingDepartment != Departments.floorTwo)
                        {
                            lbProductListStatistics.Items.RemoveAt(i);
                        }
                    }
                    break;
                case "Floor Three":
                    for (int i = lbProductListStatistics.Items.Count - 1; i >= 0; i--)
                    {
                        if (((Product)lbProductListStatistics.Items[i]).belongingDepartment != Departments.floorThree)
                        {
                            lbProductListStatistics.Items.RemoveAt(i);
                        }
                    }
                    break;
                case "Floor Four":
                    for (int i = lbProductListStatistics.Items.Count - 1; i >= 0; i--)
                    {
                        if (((Product)lbProductListStatistics.Items[i]).belongingDepartment != Departments.floorFour)
                        {
                            lbProductListStatistics.Items.RemoveAt(i);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void ReloadRestockRequests()
        {
            lbPendingRestocks.Items.Clear();
            foreach (RestockRequest request in mediaBazaar.GetRestockRequests)
            {
                lbPendingRestocks.Items.Add(request);
            }
        }

        private void btnRequestRestock_Click(object sender, EventArgs e)
        {
            if (numStockRequest.Value > 0)
            {
                foreach (Product p in lbProductListStatistics.SelectedItems)
                {
                    mediaBazaar.AddRestock(p.id, p.name, (int)numStockRequest.Value, tbRestockDescription.Text);
                }
                ReloadRestockRequests();
            }
            else
            {
                MessageBox.Show("Cannot restock 0 or less units");
            }
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            switch (cbProductSearchMethod.SelectedItem.ToString().Trim())
            {
                case "Product code":
                    ReloadProducts();
                    if (tbProductSearchAttribute.Text.Length > 0)
                    {
                        for (int i = lbProductListStatistics.Items.Count - 1; i >= 0; i--)
                        {
                            if (((Product)lbProductListStatistics.Items[i]).id != Convert.ToInt32(tbProductSearchAttribute.Text))
                            {
                                lbProductListStatistics.Items.RemoveAt(i);
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
                    ReloadProductsByFloors();
                    if (tbProductSearchAttribute.Text.Length > 0)
                    {
                        for(int i = lbProductListStatistics.Items.Count - 1; i >= 0; i--)
                        {
                            if (!((Product)lbProductListStatistics.Items[i]).name.Contains(tbProductSearchAttribute.Text))
                            {
                                lbProductListStatistics.Items.RemoveAt(i);
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

        private void cbProductDepartmentSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadProductsByFloors();
        }

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            ReloadProductsByFloors();
            ReloadRestockRequests();
        }
    }
}
