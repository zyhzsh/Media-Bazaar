using System;
using System.Windows.Forms;
using Proj_Desktop_App.logic;

namespace Proj_Desktop_App
{
    public partial class SalesManagerForm : Form
    {
        private ProductStorage prdStorage;
        private RestockRequestStorage reqStorage;
        private int salesManagerBsn;
        private Department salesManagerDepartment;

        private ListViewColumnSorter lvwColumnSorterProducts, lvwColumnSorterRestocks;

        public SalesManagerForm(int BSN, Department dep, ProductStorage prdStorage, RestockRequestStorage reqStorage)
        {
            InitializeComponent();
            this.prdStorage = prdStorage;
            this.reqStorage = reqStorage;
            this.salesManagerBsn = BSN;
            this.salesManagerDepartment = dep;
            cbProductSearchMethod.SelectedIndex = 0;

            lvwColumnSorterProducts = new ListViewColumnSorter();
            this.lvwColumnSorterProducts.SortColumn = 4;
            this.lvProducts.ListViewItemSorter = lvwColumnSorterProducts;

            ReloadProducts();

            this.lvwColumnSorterProducts.SortType = typeof(int);
            this.lvProducts.Columns[4].Text += "▲";
            this.lvProducts.Sort();

            lvwColumnSorterRestocks = new ListViewColumnSorter();
            this.lvRestocks.ListViewItemSorter = lvwColumnSorterRestocks;

            ReloadRestockRequests();

            this.lvwColumnSorterRestocks.SortType = typeof(int);
            this.lvRestocks.Columns[0].Text += "▲";
            this.lvRestocks.Sort();
        }

        private void ReloadProducts()
        {
            lvProducts.Items.Clear();

            foreach (Product p in prdStorage.ProductsByFloor(salesManagerDepartment))
            {
                ListViewItem item = new ListViewItem(p.id.ToString());
                item.SubItems.Add(p.Name);
                item.SubItems.Add(p.Brand);
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

        private void lvProducts_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader columnToSort = lvProducts.Columns[e.Column];

            // Determine if clicked column is already the column that is being sorted.
            if (columnToSort.Index == lvwColumnSorterProducts.SortColumn)
            {
                // Reverse the current sort direction for this column.
                columnToSort.Text = columnToSort.Text.Trim(new char[] { '▲', '▼' });
                if (lvwColumnSorterProducts.Order == SortOrder.Ascending)
                {
                    lvwColumnSorterProducts.Order = SortOrder.Descending;
                    columnToSort.Text += "▼";
                }
                else
                {
                    lvwColumnSorterProducts.Order = SortOrder.Ascending;
                    columnToSort.Text += "▲";
                }
            }
            else
            {
                // Set the column number that is to be sorted
                lvwColumnSorterProducts.SortColumn = columnToSort.Index;
                foreach (ColumnHeader ch in lvProducts.Columns)
                {
                    ch.Text = ch.Text.Trim(new char[] { '▲', '▼' });
                }
                // Default sort order is ascending
                lvwColumnSorterProducts.Order = SortOrder.Ascending;
                columnToSort.Text += "▲";
            }

            // Set the type of the column
            switch (e.Column)
            {
                case 0:
                case 4:
                    lvwColumnSorterProducts.SortType = typeof(double);
                    break;
                default:
                    lvwColumnSorterProducts.SortType = typeof(string);
                    break;
            }

            // Perform the sort with these new sort options.
            this.lvProducts.Sort();
        }

        private void lvRestocks_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader columnToSort = lvRestocks.Columns[e.Column];

            // Determine if clicked column is already the column that is being sorted.
            if (columnToSort.Index == lvwColumnSorterRestocks.SortColumn)
            {
                // Reverse the current sort direction for this column.
                columnToSort.Text = columnToSort.Text.Trim(new char[] { '▲', '▼' });
                if (lvwColumnSorterRestocks.Order == SortOrder.Ascending)
                {
                    lvwColumnSorterRestocks.Order = SortOrder.Descending;
                    columnToSort.Text += "▼";
                }
                else
                {
                    lvwColumnSorterRestocks.Order = SortOrder.Ascending;
                    columnToSort.Text += "▲";
                }
            }
            else
            {
                // Set the column number that is to be sorted
                lvwColumnSorterRestocks.SortColumn = columnToSort.Index;
                foreach (ColumnHeader ch in lvRestocks.Columns)
                {
                    ch.Text = ch.Text.Trim(new char[] { '▲', '▼' });
                }
                // Default sort order is ascending
                lvwColumnSorterRestocks.Order = SortOrder.Ascending;
                columnToSort.Text += "▲";
            }

            // Set the type of the column
            switch (e.Column)
            {
                case 0:
                case 1:
                case 4:
                    lvwColumnSorterRestocks.SortType = typeof(int);
                    break;
                default:
                    lvwColumnSorterRestocks.SortType = typeof(string);
                    break;
            }

            // Perform the sort with these new sort options.
            this.lvRestocks.Sort();
        }
    }
}
