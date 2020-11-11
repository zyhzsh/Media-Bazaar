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
    public partial class SalesManagerForm : Form
    {
        private DatabaseManagement dtbMan;
        public SalesManagerForm()
        {
            InitializeComponent();
            dtbMan = new DatabaseManagement();

            ReloadProducts();

            ReloadRestockRequests();
        }

        private void ReloadProducts()
        {
            lbProductListStatistics.Items.Clear();
            foreach (Product p in dtbMan.GetAllProducts())
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
                        if (((Product)lbProductListStatistics.Items[i]).Department != Departments.floorOne)
                        {
                            lbProductListStatistics.Items.RemoveAt(i);
                        }
                    }
                    break;
                case "Floor Two":
                    for (int i = lbProductListStatistics.Items.Count - 1; i >= 0; i--)
                    {
                        if (((Product)lbProductListStatistics.Items[i]).Department != Departments.floorTwo)
                        {
                            lbProductListStatistics.Items.RemoveAt(i);
                        }
                    }
                    break;
                case "Floor Three":
                    for (int i = lbProductListStatistics.Items.Count - 1; i >= 0; i--)
                    {
                        if (((Product)lbProductListStatistics.Items[i]).Department != Departments.floorThree)
                        {
                            lbProductListStatistics.Items.RemoveAt(i);
                        }
                    }
                    break;
                case "Floor Four":
                    for (int i = lbProductListStatistics.Items.Count - 1; i >= 0; i--)
                    {
                        if (((Product)lbProductListStatistics.Items[i]).Department != Departments.floorFour)
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
            foreach (RestockRequest request in dtbMan.GetPendingRestockRequests())
            {
                lbPendingRestocks.Items.Add(request);
            }
        }

        private void btnRequestRestock_Click(object sender, EventArgs e)
        {
            if (numStockRequest.Value > 0)
            {
                ReloadRestockRequests();
                foreach (Product p in lbProductListStatistics.SelectedItems)
                {
                    RestockRequest req = new RestockRequest(p.id, p.Name, 100000000, (int)numStockRequest.Value, tbRestockDescription.Text);
                    dtbMan.CreateRestockRequest(req);
                    lbPendingRestocks.Items.Add(req);
                }
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
                            if (!((Product)lbProductListStatistics.Items[i]).Name.Contains(tbProductSearchAttribute.Text))
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
            MessageBox.Show(cbProductDepartmentSelector.SelectedItem.ToString());
        }

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            ReloadProductsByFloors();
            ReloadRestockRequests();
        }
    }
}
