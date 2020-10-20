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
    public partial class DepotManagerFrom : Form
    {
        private Form1 loginForm;
        private Employee currentUser;

        private Scheduling scheduling;
        private ProductStatistics productStatistics;
        private DepotManager depotManager;

        private ToolStripMenuItem selectedMenu;
        
        public DepotManagerFrom(Form1 loginForm, Store store)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.Visible = true;

            scheduling = new Scheduling() { TopLevel = false, TopMost = true };
            scheduling.FormBorderStyle = FormBorderStyle.None;
            productStatistics = new ProductStatistics(store) { TopLevel = false, TopMost = true };
            productStatistics.FormBorderStyle = FormBorderStyle.None;
            depotManager = new DepotManager(store) { TopLevel = false, TopMost = true };
            depotManager.FormBorderStyle = FormBorderStyle.None;

            selectedMenu = null;
            miSchedule.PerformClick();
        }

        private void miSchedule_Click(object sender, EventArgs e)
        {
            if (selectedMenu != miSchedule)
            {
                selectedMenu = miSchedule;
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(scheduling);
                scheduling.Show();
            }
        }

        private void miProducts_Click(object sender, EventArgs e)
        {
            if (selectedMenu != miProducts)
            {
                selectedMenu = miProducts;
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(productStatistics);
                productStatistics.Show();
            }
        }

        private void miRestocks_Click(object sender, EventArgs e)
        {
            if (selectedMenu != miRestocks)
            {
                selectedMenu = miRestocks;
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(depotManager);
                depotManager.Show();
            }
        }

        private void miLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepotManagerFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Visible = true;
        }
    }
}
