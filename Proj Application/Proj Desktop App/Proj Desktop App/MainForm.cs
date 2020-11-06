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
    public partial class MainForm : Form
    {
        private Form1 loginForm;

        private EmployeesForm employeesForm;
        private EmployeeContractsForm contractsForm;

        private ProductStatistics productStatistics;
        private Form restocks;
        private Scheduling scheduling;

        private ToolStripMenuItem selectedTab;

        public MainForm(Form1 loginForm, Store store, PositionType position)
        {
            InitializeComponent();
            this.Visible = true;
            if (position == PositionType.Administrator)
            {
                tabEmployees.Visible = true;
                employeesForm = new EmployeesForm(store);
                InitializeForm(employeesForm);

                tabContracts.Visible = true;
                contractsForm = new EmployeeContractsForm();
                InitializeForm(contractsForm);

                tabDepartments.Visible = true;

                selectedTab = null;
                tabEmployees.PerformClick();
            }
            else if (position == PositionType.Depot_Manager)
            {
                tabProducts.Visible = true;
                tabStatistics.Visible = true;
                productStatistics = new ProductStatistics();
                InitializeForm(productStatistics);

                tabRestocks.Visible = true;
                restocks = new DepotManager(store);
                InitializeForm(restocks);

                tabSchedule.Visible = true;
                scheduling = new Scheduling(Departments.warehouse);
                InitializeForm(scheduling);

                tabProducts.PerformClick();
            }
            else if (position == PositionType.Depot_Worker)
            {
                tabRestocks.Visible = true;
                restocks = new WorkerStockRequests(store);
                InitializeForm(restocks);

                tabRestocks.PerformClick();
            }
            else if (position == PositionType.Sales_Manager)
            {
                tabRestocks.Visible = true;
                restocks = new SalesManagerForm(store);
                InitializeForm(restocks);

                tabSchedule.Visible = true;
                scheduling = new Scheduling(Departments.floorOne);
                InitializeForm(scheduling);

                tabRestocks.PerformClick();
            }
            else { this.Close(); }
           

            this.loginForm = loginForm;

            lblUser.Text = $"{position} | <user>";
        }

        private void InitializeForm(Form form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
        }

        private void ShowForm(Form form, ToolStripMenuItem newTab)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(form);
            form.Show();
            if (selectedTab != null) { selectedTab.BackColor = Color.Transparent; }
            selectedTab = newTab;
            selectedTab.BackColor = Color.LightSteelBlue;
        }

        private void tabEmployees_Click(object sender, EventArgs e)
        {
            if (selectedTab != tabEmployees)
            {
                ShowForm(employeesForm, tabEmployees);
            }
        }

        private void tabContracts_Click(object sender, EventArgs e)
        {
            if (selectedTab != tabContracts)
            {
                ShowForm(contractsForm, tabContracts);
            }
        }

        private void tabDepartments_Click(object sender, EventArgs e)
        {
            if (selectedTab != tabDepartments)
            {
                //ShowForm(scheduling, tabDepartments);
            }
        }

        private void tabProducts_Click(object sender, EventArgs e)
        {
            if (selectedTab != tabProducts)
            {
                ShowForm(restocks, tabProducts);
            }
        }

        private void tabStatistics_Click(object sender, EventArgs e)
        {
            if (selectedTab != tabStatistics)
            {
                ShowForm(productStatistics, tabStatistics);
            }
        }

        private void tabRestocks_Click(object sender, EventArgs e)
        {
            if (selectedTab != tabRestocks)
            {
                ShowForm(restocks, tabRestocks);
            }
        }

        private void tabSchedule_Click(object sender, EventArgs e)
        {
            if (selectedTab != tabSchedule)
            {
                ShowForm(scheduling, tabSchedule);
            }
        }

        private void tabLogOut_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show login form
            loginForm.Visible = true;
        }

    }
}
