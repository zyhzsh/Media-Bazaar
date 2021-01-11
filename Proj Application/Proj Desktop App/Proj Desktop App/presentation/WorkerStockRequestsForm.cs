using System;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public partial class WorkerStockRequestsForm : Form
    {
        private RestockRequestStorage RequestStorage;
        private int currentUserBSN;

        public WorkerStockRequestsForm(int BSN, RestockRequestStorage requestStorage)
        {
            InitializeComponent();
            this.RequestStorage = requestStorage;
            currentUserBSN = BSN;
            ReloadRequests();
        }

        private void ReloadRequests()
        {
            lvRestocks.Items.Clear();
            foreach (RestockRequest request in RequestStorage.GetAccepted())
            {
                if (request != null)
                {
                    ListViewItem item = new ListViewItem(request.restockID.ToString());
                    item.SubItems.Add(request.productCode.ToString());
                    item.SubItems.Add(request.productName);
                    item.SubItems.Add(request.requester_desc);
                    item.SubItems.Add(request.judge_desc);
                    item.SubItems.Add(request.restockAmount.ToString());

                    lvRestocks.Items.Add(item);
                }
            }

            foreach (ColumnHeader column in lvRestocks.Columns)
            {
                if (column.Text == "Response Message" || column.Text == "Request Message")
                {
                    column.Width = -1;
                }
            }
        }

        private void btnCompleteRestock_Click(object sender, EventArgs e)
        {
            if (lvRestocks.SelectedItems.Count > 0 && numRestockedAmount.Value > 0)
            {
                for (int i = lvRestocks.SelectedItems.Count - 1; i >= 0; i--)
                {
                    RequestStorage.CompleteRequest(Convert.ToInt32(lvRestocks.SelectedItems[i].Text), currentUserBSN, (int)numRestockedAmount.Value, rtbRestockRequestComment.Text);
                }
                MessageBox.Show("Requests completed");
                ReloadRequests();
            }
            else
            {
                MessageBox.Show("No requests selected");
            }
        }
    }
}
