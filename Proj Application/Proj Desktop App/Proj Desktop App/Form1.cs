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
    public partial class Form1 : Form
    {
        // Login credentials:
        //
        // ADMINISTRATOR:
        // Username: jguttridge4
        // Password: uYFLTrkmOqVq
        //
        // DEPOT MANAGER:
        // Username: gdambrogi6
        // Password: LbZAsgys63h
        //
        // DEPOT WORKER:
        // Username: rgrisleyf
        // Password: RaX3pQ1P

        private Store mediaBazaar;
        private LoginHandler loginHandler;

        public Form1()
        {
            InitializeComponent();
            mediaBazaar = new Store();
            loginHandler = new LoginHandler();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            PositionType position = loginHandler.CheckLogin(tbLogInUsername.Text, tbLogInPassword.Text);
            if (position == PositionType.Administrator)
            {
                // open administrotor form
                new AdministratorForm(this, mediaBazaar);
                this.Visible = false;
                tbLogInUsername.Clear();
                tbLogInPassword.Clear();
            }
            else if (position == PositionType.Depot_Worker)
            {
                // open depot worker form
                new DepotWorkerForm(this, mediaBazaar);
                this.Visible = false;
                tbLogInUsername.Clear();
                tbLogInPassword.Clear();
            }
            else if (position == PositionType.Sales_Manager)
            {
                // open sales manager form
                
            }
            else if (position == PositionType.Depot_Manager)
            {
                // open depot manager form
                new DepotManagerFrom(this, mediaBazaar);
                this.Visible = false;
                tbLogInUsername.Clear();
                tbLogInPassword.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void btnProductStatisticsMenu_Click(object sender, EventArgs e)
        {
            ProductStatistics productStatistics = new ProductStatistics(mediaBazaar);
            productStatistics.Show(this);
        }

        private void btnDepotManager_Click(object sender, EventArgs e)
        {
            DepotManager depotManager = new DepotManager(mediaBazaar);
            depotManager.Show(this);
        }

        private void btnDepotWorkerForm_Click(object sender, EventArgs e)
        {
            WorkerStockRequests RestockForm = new WorkerStockRequests(mediaBazaar);
            RestockForm.Show(this);
        }

        private void btnOpenSchedule_Click(object sender, EventArgs e)
        {
            Scheduling scheduleForm = new Scheduling(Departments.floorOne);
            scheduleForm.Show(this);
        }
    }
}
