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
    public partial class DepotWorkerForm : Form
    {
        private Form1 loginForm;
        private Employee currentUser;

        private WorkerStockRequests stockRequests;

        private ToolStripMenuItem selectedMenu;

        public DepotWorkerForm(Form1 loginForm, Store store)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.Visible = true;

            stockRequests = new WorkerStockRequests(store) { TopLevel = false, TopMost = true };
            stockRequests.FormBorderStyle = FormBorderStyle.None;

            selectedMenu = null;
            miRestocks.PerformClick();
        }

        private void miRestocks_Click(object sender, EventArgs e)
        {
            if (selectedMenu != miRestocks)
            {
                selectedMenu = miRestocks;
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(stockRequests);
                stockRequests.Show();
            }
        }

        private void miLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepotWorkerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Visible = true;
        }
    }
}
