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
    public partial class AdministratorForm : Form
    {
        private Form1 loginForm;
        private Store store;

        public AdministratorForm(Form1 form1, Store store)
        {
            InitializeComponent();
            this.loginForm = form1;
            this.store = store;
            this.Visible = true;
            lbEmployees.Items.Clear();
            lbEmployees.Items.AddRange(store.GetEmployees());
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            new EmployeeManagmentForm(this);
        }

        public bool AddNewEmployee(int BSN, string firstName, string lastName, char gender, string phoneNumber, DateTime birthDate,
            string address, string certificates, string status, Departments department, string contactEmail, double fte, PositionType positionType, string jobTitle)
        {
            // create new Employee
            if (store.AddEmployee( BSN,  firstName,  lastName,  gender,  phoneNumber,  birthDate,
                address,  certificates,  status,  department,  contactEmail,  fte, positionType, jobTitle))
            {
                lbEmployees.Items.Clear();
                lbEmployees.Items.AddRange(store.GetEmployees());
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            // get employee based on bsn
            int bsn = Convert.ToInt32(tbBSN.Text);
            Employee employee = store.GetEmployee(bsn);
            if (employee != null)
            {
                MessageBox.Show(employee.ToString());
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            int bsn = Convert.ToInt32(tbBSN.Text);
            new EmployeeManagmentForm(this, bsn);
        }

        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            //get employee based on bsn
            int bsn = Convert.ToInt32(tbBSN.Text);
            Employee employee = store.GetEmployee(bsn);
            if (employee != null)
            {
                employee.UpdateStatus("Fired");
            }
            //change employee status
        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex >= 0)
            {
                string employeeInfo = lbEmployees.SelectedItem.ToString();
                int indexOfDash = employeeInfo.IndexOf('-');
                string bsn = employeeInfo.Substring(0, indexOfDash - 1);
                tbBSN.Text = bsn;
            }
        }
    }
}
