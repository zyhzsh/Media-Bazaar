﻿using System;
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
        private Store mediaBazaar;
        private Login login;

        public Form1()
        {
            InitializeComponent();
            mediaBazaar = new Store();
            login = new Login();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            PositionType position = login.CheckLogin(tbLogInUsername.Text, tbLogInPassword.Text);
            if (position == PositionType.Administrator)
            {
                // open admin form
                new AdministratorForm(this, mediaBazaar);
            }
            else if (position == PositionType.Depot_Worker)
            {
                // open depot worker form
            }
            else if (position == PositionType.Sales_Manager)
            {
                // open sales manager form
            }
            else if (position == PositionType.Depot_Manager)
            {
                // open depot manager form
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void btStatistics_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Scheduling a = new Scheduling();
            a.Show();
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
            Scheduling scheduleForm = new Scheduling();
            scheduleForm.Show(this);
        }
    }
}
