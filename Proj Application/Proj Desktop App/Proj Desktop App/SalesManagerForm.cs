using Proj_Desktop_App.dataAccess;
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
        private ProductStorage prdStorage;
        private RestockRequestStorage reqStorage;
        private int salesManagerBsn;
        private Departments salesManagerDepartment;
        public SalesManagerForm(int BSN, Departments dep, ProductStorage prdStorage, RestockRequestStorage reqStorage)
        {
            InitializeComponent();
            this.prdStorage = prdStorage;
            this.reqStorage = reqStorage;
            this.salesManagerBsn = BSN;
            this.salesManagerDepartment = dep;
            ReloadProducts();

            ReloadRestockRequests();
        }

        private void ReloadProducts()
        {
            lbProducts.Items.Clear();
            foreach (Product p in prdStorage.ProductsByFloor(salesManagerDepartment))
            {
                lbProducts.Items.Add(p);
            }
        }

        private void ReloadRestockRequests()
        {
            lbPendingRestocks.Items.Clear();
            foreach (RestockRequest request in reqStorage.GetPending())
            {
                lbPendingRestocks.Items.Add(request);
            }
        }

        private void btnRequestRestock_Click(object sender, EventArgs e)
        {
            if (numStockRequest.Value > 0)
            {
                ReloadRestockRequests();
                foreach (Product p in lbProducts.SelectedItems)
                {
                    RestockRequest req = new RestockRequest(p.id, p.Name, this.salesManagerBsn, (int)numStockRequest.Value, tbRestockDescription.Text, "PENDING");
                    reqStorage.Add(req);
                    ReloadRestockRequests();
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
                        for (int i = lbProducts.Items.Count - 1; i >= 0; i--)
                        {
                            if (((Product)lbProducts.Items[i]).id != Convert.ToInt32(tbProductSearchAttribute.Text))
                            {
                                lbProducts.Items.RemoveAt(i);
                            }
                        }
                        lbProducts.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("textbox is empty");
                    }
                    break;
                case "Product name":
                    //ReloadProductsByFloors();
                    if (tbProductSearchAttribute.Text.Length > 0)
                    {
                        for(int i = lbProducts.Items.Count - 1; i >= 0; i--)
                        {
                            if (!((Product)lbProducts.Items[i]).Name.Contains(tbProductSearchAttribute.Text))
                            {
                                lbProducts.Items.RemoveAt(i);
                            }
                        }
                        lbProducts.Refresh();
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
            //ReloadProductsByFloors();
            //MessageBox.Show(cbProductDepartmentSelector.SelectedItem.ToString());
        }

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            ReloadProducts();
            ReloadRestockRequests();
        }
    }
}
