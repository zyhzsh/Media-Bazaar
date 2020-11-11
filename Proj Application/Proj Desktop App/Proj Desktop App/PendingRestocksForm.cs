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
        private ProcuctManagement dtbMan;
        public PendingRestocksForm(int BSN)
        {
            InitializeComponent();
            dtbMan = new ProcuctManagement();
            ReloadRequests();
        }

        private void ReloadRequests()
        {
            lbIncomingRestocks.Items.Clear();
            foreach (RestockRequest request in dtbMan.GetPendingRestockRequests())
            {
                lbIncomingRestocks.Items.Add(request);
            }
        }

        private void btnAcceptRestock_Click(object sender, EventArgs e)
        {
            if (lbIncomingRestocks.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No restocks selected");
            }
            else
            {
                for (int i = lbIncomingRestocks.SelectedItems.Count - 1; i >= 0; i--)
                {
                    RestockRequest resItem = (RestockRequest)lbIncomingRestocks.SelectedItems[i];
                    dtbMan.AcceptRestockRequest(resItem.restockID, 100000000, rtbRestockJustification.Text);
                }
            }
            ReloadRequests();
        }

        private void btnRejectRestock_Click(object sender, EventArgs e)
        {
            for (int i = lbIncomingRestocks.SelectedItems.Count - 1; i >= 0; i--)
            {
                RestockRequest resItem = (RestockRequest)lbIncomingRestocks.SelectedItems[i];
                dtbMan.DeclineRestockRequest(resItem.restockID, 100000000, rtbRestockJustification.Text);
            }
            ReloadRequests();
        }

        private void btnDepotRefresh_Click(object sender, EventArgs e)
        {
            ReloadRequests();
        }
    }
}
