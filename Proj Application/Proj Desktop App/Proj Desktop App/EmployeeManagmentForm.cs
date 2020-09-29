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
    public partial class EmployeeManagmentForm : Form
    {
        private AdministratorForm adminForm;
        private bool updateEmployee;

        private void InitializeElements()
        {
            this.Visible = true;
            cbDepartment.DataSource = Enum.GetValues(typeof(Departments));
            cbPosition.DataSource = Enum.GetValues(typeof(PositionType));
        }

        public EmployeeManagmentForm(AdministratorForm adminForm)
        {
            InitializeComponent();
            InitializeElements();
            this.adminForm = adminForm;
            updateEmployee = false;
            Text = "New Employee Form";
            btnConfirm.Text = "Add new employee";
        }

        public EmployeeManagmentForm(AdministratorForm adminForm, int bsn)
        {
            InitializeComponent();
            InitializeElements();
            this.adminForm = adminForm;
            updateEmployee = true;

            // get employee object with this bsn
            // fill in elements with current info

            tbBSN.Text = bsn.ToString();
            tbBSN.Enabled = false;
            dtpBirthdate.Enabled = false;
            btnConfirm.Text = "Save changes";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int bsn;
            string firstName;
            string lastName;
            char gender = 'O';
            DateTime birthdate;
            string phone;
            string address;
            string email;
            Departments department;
            PositionType position;
            string jobTitle;
            double fte;
            
            string certificates;

            if (!updateEmployee)
            {
                // create new employee object
                try
                {
                    bsn = Convert.ToInt32(tbBSN.Text);
                    firstName = tbFirstName.Text;
                    lastName = tbLastName.Text;
                    birthdate = dtpBirthdate.Value;
                    phone = tbPhone.Text;
                    address = tbAddress.Text;
                    email = tbEmail.Text;
                    department = (Departments)cbDepartment.SelectedItem;
                    position = (PositionType)cbPosition.SelectedItem;
                    jobTitle = tbJobTitle.Text;
                    fte = Convert.ToDouble(nudFTE.Value);
                    
                    certificates = tbCertificates.Text;
                    if (rbMale.Checked)
                    {
                        gender = 'M';
                    }
                    else if (rbFemale.Checked)
                    {
                        gender = 'F';
                    }

                    if (adminForm.AddNewEmployee(bsn, firstName, lastName, gender, phone, birthdate, address, certificates, "Employed",
                        department, email, fte, position, jobTitle))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("An employee with this BSN already exists!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check your details.");
                }

            }
            else
            {
                // change some info
            }

          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string confirmQuestion = "Are you sure you want to cancel?";
            DialogResult confirmResult = MessageBox.Show(confirmQuestion, "Confirm cancel", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((PositionType)cbPosition.SelectedItem == PositionType.Other)
            {
                tbJobTitle.Enabled = true;
                tbJobTitle.Clear();
            }
            else
            {
                tbJobTitle.Text = cbPosition.SelectedItem.ToString();
            }
        }
    }
}
