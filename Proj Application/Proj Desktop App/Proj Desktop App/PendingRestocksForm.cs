using Proj_Desktop_App.dataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public partial class PendingRestocksForm : Form
    {
        private RestockRequestStorage reqStorage;
        private int currentUserBsn;
        public PendingRestocksForm(int BSN, RestockRequestStorage requestStorage)
        {
            InitializeComponent();
            reqStorage = requestStorage;
            currentUserBsn = BSN;
            ReloadRequests();
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
            if(lvRestocks.SelectedItems.Count <= 0)
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
    }
}
