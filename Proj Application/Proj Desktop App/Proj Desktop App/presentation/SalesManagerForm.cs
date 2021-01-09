using System;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public partial class SalesManagerForm : Form
    {
        private ProductStorage prdStorage;
        private RestockRequestStorage reqStorage;
        private int salesManagerBsn;
        private Department salesManagerDepartment;
        public SalesManagerForm(int BSN, Department dep, ProductStorage prdStorage, RestockRequestStorage reqStorage)
        {
            InitializeComponent();
            this.prdStorage = prdStorage;
            this.reqStorage = reqStorage;
            this.salesManagerBsn = BSN;
            this.salesManagerDepartment = dep;
            cbProductSearchMethod.SelectedIndex = 0;

            ReloadProducts();

            ReloadRestockRequests();
        }

        private void ReloadProducts()
        {
            lvProducts.Items.Clear();

            foreach (Product p in prdStorage.ProductsByFloor(salesManagerDepartment))
            {
                ListViewItem item = new ListViewItem(p.id.ToString());
                item.SubItems.Add(p.Name);
                item.SubItems.Add(p.Brand);
                item.SubItems.Add(p.Description);
                item.SubItems.Add(p.SoldPrice.ToString());
                item.SubItems.Add(p.BoughtPrice.ToString());
                item.SubItems.Add(p.Department.ToString());
                item.SubItems.Add(p.Stock.ToString());

                lvProducts.Items.Add(item);
            }

            foreach (ColumnHeader column in lvProducts.Columns)
            {
                if (column.Text == "Name" || column.Text == "Brand")
                {
                    column.Width = -1;
                }
            }
        }

        private void ReloadRestockRequests()
        {
            lvRestocks.Items.Clear();
            foreach (RestockRequest request in reqStorage.GetPending())
            {
                ListViewItem item = new ListViewItem(request.restockID.ToString());
                item.SubItems.Add(request.productCode.ToString());
                item.SubItems.Add(request.productName.ToString());
                item.SubItems.Add(request.requester_desc);
                item.SubItems.Add(request.restockAmount.ToString());

                lvRestocks.Items.Add(item);
            }

            foreach (ColumnHeader column in lvRestocks.Columns)
            {
                if (column.Text == "Request Message" || column.Text == "Product Name")
                {
                    column.Width = -1;
                    if (lvRestocks.Items.Count <= 0)
                        column.Width = -2;
                }
            }
        }

        private void btnRequestRestock_Click(object sender, EventArgs e)
        {
            if (numStockRequest.Value > 0)
            {
                ReloadRestockRequests();
                foreach (ListViewItem item in lvProducts.SelectedItems)
                {
                    RestockRequest req = new RestockRequest(Convert.ToInt32(item.Text), item.SubItems[0].Text, salesManagerDepartment, this.salesManagerBsn, (int)numStockRequest.Value, tbRestockDescription.Text, "PENDING");
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
                        for (int i = lvProducts.Items.Count - 1; i >= 0; i--)
                        {
                            if (lvProducts.Items[i].Text != tbProductSearchAttribute.Text)
                            {
                                lvProducts.Items.RemoveAt(i);
                            }
                        }
                        lvProducts.Refresh();
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
                        for (int i = lvProducts.Items.Count - 1; i >= 0; i--)
                        {
                            if (!lvProducts.Items[i].SubItems[1].ToString().Contains(tbProductSearchAttribute.Text))
                            {
                                lvProducts.Items.RemoveAt(i);
                            }
                        }
                        lvProducts.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("textbox is empty");
                    }
                    break;

            }
        }

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            ReloadProducts();
            ReloadRestockRequests();
        }
    }
}
