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
        private Store mediabazaar;
        public WorkerStockRequests(Store Form1mediabazaar)
        {
            InitializeComponent();
            mediabazaar = Form1mediabazaar;
            ReloadRequests();
        }

        private void ReloadRequests()
        {
            lbRestockRequests.Items.Clear();
            foreach (RestockRequest request in mediabazaar.GetRestockOrders)
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
                    mediabazaar.RestockProduct(request.GetProductId, request.GetRestockAmount);
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
