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
    public partial class WorkerStockRequests : Form
    {
        private ProcuctManagement dtbMan;
        public WorkerStockRequests()
        {
            InitializeComponent();
            dtbMan = new ProcuctManagement();
            ReloadRequests();
        }

        private void ReloadRequests()
        {
            lbRestockRequests.Items.Clear();
            foreach (RestockRequest request in dtbMan.GetAcceptedRestockRequests())
            {
                lbRestockRequests.Items.Add(request);
            }
        }

        private void btnCompleteRestock_Click(object sender, EventArgs e)
        {
            if (lbRestockRequests.SelectedItems.Count > 0)
            {
                for (int i = lbRestockRequests.SelectedItems.Count - 1; i >= 0; i--)
                {
                    RestockRequest request = ((RestockRequest) lbRestockRequests.SelectedItems[i]);
                    dtbMan.RestockProduct(request, 100000000, (int)numRestockedAmount.Value, rtbRestockRequestComment.Text);
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
