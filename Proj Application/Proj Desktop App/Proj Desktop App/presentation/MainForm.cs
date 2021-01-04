using Proj_Desktop_App.presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proj_Desktop_App.presentation;

namespace Proj_Desktop_App
{
    public partial class MainForm : Form
    {
        // Parent form
        private LoginForm loginForm;

        // Forms to include in tabs
        private AdminForm employeesForm;
        private ProductCRUDForm productCRUD;
        private ProductStatistics productStatistics;
        private Form restocks;
        private Scheduling scheduling;
        
        private RequestInfoChangeForm requestInfoChange;
        private WeeklyScheduleGridForm autoSchedule;

        // Selected tab
        private ToolStripMenuItem selectedTab;

        // Logic layer
        private ProductStorage prdStorage;
        private RestockRequestStorage reqStorage;

        public MainForm(LoginForm loginForm, Employee currentUser)
        {
            InitializeComponent();
            this.Visible = true;
            selectedTab = null;
            PositionType position = currentUser.GetPosition();
            if (position == PositionType.Administrator)
            {
                tabEmployees.Visible = true;
                employeesForm = new AdminForm();
                InitializeForm(employeesForm);
                tabDepartments.Visible = true;
                tabEmployees.PerformClick();

                tabRequestInfoChange.Visible = true;
                requestInfoChange = new RequestInfoChangeForm();
                InitializeForm(requestInfoChange);
            }
            else if (position == PositionType.Depot_Manager)
            {
                prdStorage = new ProductStorage();
                reqStorage = new RestockRequestStorage(); 
                // Schedule

                tabProducts.Visible = true;
                productCRUD = new ProductCRUDForm(prdStorage);
                InitializeForm(productCRUD);

                tabStatistics.Visible = true;
                productStatistics = new ProductStatistics();
                InitializeForm(productStatistics);

                tabRestocks.Visible = true;
                restocks = new PendingRestocksForm(currentUser.GetBSN(), reqStorage);
                InitializeForm(restocks);

                tabSchedule.Visible = true;
                scheduling = new Scheduling(currentUser.GetDepartment());
                InitializeForm(scheduling);

                tabAutoSchedule.Visible = true;
                autoSchedule = new WeeklyScheduleGridForm(currentUser.GetDepartment());
                InitializeForm(autoSchedule);


                tabProducts.PerformClick();
            }
            else if (position == PositionType.Depot_Worker)
            {
                reqStorage = new RestockRequestStorage();

                tabRestocks.Visible = true;
                restocks = new WorkerStockRequestsForm(currentUser.GetBSN(), reqStorage);
                InitializeForm(restocks);

                tabRestocks.PerformClick();
            }
            else if (position == PositionType.Sales_Manager)
            {
                prdStorage = new ProductStorage();
                reqStorage = new RestockRequestStorage();

                tabRestocks.Visible = true;
                restocks = new SalesManagerForm(currentUser.GetBSN(), currentUser.GetDepartment(), prdStorage, reqStorage);
                InitializeForm(restocks);

                tabSchedule.Visible = true;
                scheduling = new Scheduling(currentUser.GetDepartment());
                InitializeForm(scheduling);

                tabAutoSchedule.Visible = true;
                autoSchedule = new WeeklyScheduleGridForm(currentUser.GetDepartment());
                InitializeForm(autoSchedule);

                tabRestocks.PerformClick();
            }
            else { this.Close(); }

            this.loginForm = loginForm;

            lblUser.Text = $"{position} | {currentUser.firstName} {currentUser.lastName}";
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
                ShowForm(productCRUD, tabProducts);
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

        private void requestInfoChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedTab != tabSchedule)
            {
                ShowForm(requestInfoChange, tabRequestInfoChange);
            }
        }
        
        private void tabAutoSchedule_Click(object sender, EventArgs e)
        {
            if (selectedTab != tabAutoSchedule)
            {
                ShowForm(autoSchedule, tabAutoSchedule);
            }
        }
    }
}
