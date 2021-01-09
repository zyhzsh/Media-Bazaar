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
        private DepartmentsForm departmentsForm;
        private ProductCRUDForm productCRUD;
        private ProductStatistics productStatistics;
        private Form restocks;
        private Scheduling scheduling;

        // Selected tab
        private ToolStripMenuItem selectedTab;

        // Logic layer
        //ScheduleStorage?
        private EmployeeStorage emplStorage;
        private ProductStorage prdStorage;
        private RestockRequestStorage reqStorage;

        // Departments
        private DepartmentStorage deptStorage;

        public MainForm(LoginForm loginForm, Employee currentUser, DepartmentStorage departments)
        {
            InitializeComponent();
            this.Visible = true;
            selectedTab = null;
            PositionType position = currentUser.GetPosition();
            deptStorage = departments;
            if (position == PositionType.Administrator)
            {
                emplStorage = new EmployeeStorage(deptStorage);

                tabEmployees.Visible = true;
                employeesForm = new AdminForm(emplStorage, deptStorage);
                InitializeForm(employeesForm);

                tabDepartments.Visible = true;
                departmentsForm = new DepartmentsForm(emplStorage, prdStorage, deptStorage);
                InitializeForm(departmentsForm);

                tabEmployees.PerformClick();
            }
            else if (position == PositionType.Depot_Manager)
            {
                prdStorage = new ProductStorage(deptStorage);
                reqStorage = new RestockRequestStorage(deptStorage); 
                // Schedule

                tabProducts.Visible = true;
                productCRUD = new ProductCRUDForm(prdStorage, deptStorage);
                InitializeForm(productCRUD);

                tabStatistics.Visible = true;
                productStatistics = new ProductStatistics(deptStorage);
                InitializeForm(productStatistics);

                tabRestocks.Visible = true;
                restocks = new PendingRestocksForm(currentUser.GetBSN(), reqStorage);
                InitializeForm(restocks);

                tabSchedule.Visible = true;
                scheduling = new Scheduling(currentUser.GetDepartment(), deptStorage);
                InitializeForm(scheduling);

                tabProducts.PerformClick();
            }
            else if (position == PositionType.Depot_Worker)
            {
                reqStorage = new RestockRequestStorage(deptStorage);

                tabRestocks.Visible = true;
                restocks = new WorkerStockRequestsForm(currentUser.GetBSN(), reqStorage);
                InitializeForm(restocks);

                tabRestocks.PerformClick();
            }
            else if (position == PositionType.Sales_Manager)
            {
                prdStorage = new ProductStorage(deptStorage);
                reqStorage = new RestockRequestStorage(deptStorage);

                tabRestocks.Visible = true;
                restocks = new SalesManagerForm(currentUser.GetBSN(), currentUser.GetDepartment(), prdStorage, reqStorage);
                InitializeForm(restocks);

                tabSchedule.Visible = true;
                scheduling = new Scheduling(currentUser.GetDepartment(), deptStorage);
                InitializeForm(scheduling);

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

    }
}
