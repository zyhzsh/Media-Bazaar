using System;
using System.Windows.Forms;
using Proj_Desktop_App.logic;

namespace Proj_Desktop_App
{
    public partial class PendingRestocksForm : Form
    {
        private RestockRequestStorage reqStorage;
        private int currentUserBsn;

        private ListViewColumnSorter lvwColumnSorter;

        public PendingRestocksForm(int BSN, RestockRequestStorage requestStorage)
        {
            InitializeComponent();
            reqStorage = requestStorage;
            currentUserBsn = BSN;

            lvwColumnSorter = new ListViewColumnSorter();
            this.lvRestocks.ListViewItemSorter = lvwColumnSorter;

            ReloadRequests();

            this.lvwColumnSorter.SortType = typeof(int);
            this.lvRestocks.Columns[0].Text += "▲";
            this.lvRestocks.Sort();
        }

        private void ReloadRequests()
        {
            lvRestocks.Items.Clear();
            foreach (RestockRequest request in reqStorage.GetPending())
            {
                if (request != null)
                {
                    ListViewItem item = new ListViewItem(request.restockID.ToString());
                    item.SubItems.Add(request.productCode.ToString());
                    item.SubItems.Add(request.productName);
                    item.SubItems.Add(request.requester_desc);
                    item.SubItems.Add(request.restockAmount.ToString());

                    lvRestocks.Items.Add(item);
                }
            }

            foreach (ColumnHeader column in lvRestocks.Columns)
            {
                if (column.Text == "Product Name" || column.Text == "Request Message")
                {
                    column.Width = -1;
                }
            }
        }

        private void btnAcceptRestock_Click(object sender, EventArgs e)
        {
            if (lvRestocks.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No restocks selected");
            }
            else
            {
                for (int i = lvRestocks.SelectedItems.Count - 1; i >= 0; i--)
                {
                    reqStorage.Accept(Convert.ToInt32(lvRestocks.Items[i].Text), currentUserBsn, rtbRestockJustification.Text);
                }
            }
            ReloadRequests();
        }

        private void btnRejectRestock_Click(object sender, EventArgs e)
        {
            if (lvRestocks.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No restocks selected");
            }
            else
            {
                for (int i = lvRestocks.SelectedItems.Count - 1; i >= 0; i--)
                {
                    reqStorage.Decline(Convert.ToInt32(lvRestocks.Items[i].Text), currentUserBsn, rtbRestockJustification.Text);
                }
            }
            ReloadRequests();
        }

        private void btnDepotRefresh_Click(object sender, EventArgs e)
        {
            ReloadRequests();
        }

        private void lvRestocks_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader columnToSort = lvRestocks.Columns[e.Column];

            // Determine if clicked column is already the column that is being sorted.
            if (columnToSort.Index == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                columnToSort.Text = columnToSort.Text.Trim(new char[] { '▲', '▼' });
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                    columnToSort.Text += "▼";
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                    columnToSort.Text += "▲";
                }
            }
            else
            {
                // Set the column number that is to be sorted
                lvwColumnSorter.SortColumn = columnToSort.Index;
                foreach (ColumnHeader ch in lvRestocks.Columns)
                {
                    ch.Text = ch.Text.Trim(new char[] { '▲', '▼' });
                }
                // Default sort order is ascending
                lvwColumnSorter.Order = SortOrder.Ascending;
                columnToSort.Text += "▲";
            }

            // Set the type of the column
            switch (e.Column)
            {
                case 0:
                case 1:
                case 4:
                    lvwColumnSorter.SortType = typeof(int);
                    break;
                default:
                    lvwColumnSorter.SortType = typeof(string);
                    break;
            }

            // Perform the sort with these new sort options.
            this.lvRestocks.Sort();
        }
    }
}
