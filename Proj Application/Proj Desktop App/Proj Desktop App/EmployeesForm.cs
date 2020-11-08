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
    public partial class EmployeesForm : Form
    {
        private Store store;

        public EmployeesForm(Store store)
        {
            InitializeComponent();
            this.store = store;
            this.Visible = true;
            lbEmployees.Items.Clear();
            lbEmployees.Items.AddRange(store.GetEmployees());
        }

        public void UpdateEmployees()
        {
            // EVENT LISTENER
            lbEmployees.Items.Clear();
            lbEmployees.Items.AddRange(store.GetEmployees());
            lblTotalEmployees.Text = "Total employees: " + store.GetEmployees().Length;
        }

        private int GetSelectedBSN()
        {
            if (lbEmployees.SelectedIndex > -1)
            {
                try
                {
                    string employeeInfo = lbEmployees.SelectedItem.ToString();
                    int indexOfDash = employeeInfo.IndexOf('-');
                    string bsnString = employeeInfo.Substring(0, indexOfDash - 1);
                    int bsn = Convert.ToInt32(bsnString);
                    return bsn;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Please select an employee");
                return -1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            new EmployeeManagmentForm(store);
            // But after form is cloed:
            UpdateEmployees();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            // get employee based on bsn

            int bsn = GetSelectedBSN();
            if (bsn != -1)
            {
                Employee employee = store.GetEmployee(bsn);
                if (employee != null)
                {
                    MessageBox.Show(employee.ToString());
                }
            }
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            int bsn = GetSelectedBSN();
            if (bsn != -1)
            {
                Employee employee = store.GetEmployee(bsn);
                EmployeeManagmentForm updateForm = new EmployeeManagmentForm(store, employee);
                if (updateForm.IsDisposed)
                {
                    UpdateEmployees();
                }
            }
        }

        private void btnViewContract_Click(object sender, EventArgs e)
        {
            int bsn = GetSelectedBSN();
            if (bsn != -1)
            {
                // contract
            }
        }
    }
}
