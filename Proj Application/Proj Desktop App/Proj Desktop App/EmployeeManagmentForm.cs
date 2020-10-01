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
            cbPosition.DataSource = Enum.GetValues(typeof(PositionType));
            cbDepartment.DataSource = Enum.GetValues(typeof(Departments));
        }

        public EmployeeManagmentForm(AdministratorForm adminForm)
        {
            InitializeComponent();
            InitializeElements();
            this.adminForm = adminForm;
            updateEmployee = false;
            Text = "New Employee Form";
            btnConfirm.Text = "Add new employee";
            rbMale.Checked = true;
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
            char gender;
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

                firstName = tbFirstName.Text;
                lastName = tbLastName.Text;
                phone = tbPhone.Text;
                address = tbAddress.Text;
                email = tbEmail.Text;
                jobTitle = tbJobTitle.Text;
                certificates = tbCertificates.Text;
                // check string inputs
                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                    string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(jobTitle) ||
                    string.IsNullOrWhiteSpace(certificates))
                {
                    MessageBox.Show("Please fill in all employee data.");
                }
                else
                {
                    try
                    {
                        bsn = Convert.ToInt32(tbBSN.Text);
                        birthdate = dtpBirthdate.Value;
                        department = (Departments)cbDepartment.SelectedItem;
                        position = (PositionType)cbPosition.SelectedItem;
                        fte = Convert.ToDouble(nudFTE.Value);
                        if (rbMale.Checked) { gender = 'M'; }
                        else if (rbFemale.Checked) { gender = 'F'; }
                        else { gender = 'O'; }

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
                        MessageBox.Show("Please input a valid BSN.");
                    }
                }
            }
            else
            {
                // Update employee data
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
            PositionType selectedPosition = (PositionType)cbPosition.SelectedItem;
            //cbDepartment.Items.Add(Departments.office);
            //cbDepartment.Items.Add(Departments.warehouse);
            if (selectedPosition == PositionType.Administrator)
            {
                cbDepartment.SelectedItem = Departments.office;
                cbDepartment.Enabled = false;
                tbJobTitle.Text = cbPosition.SelectedItem.ToString();
            }
            else if (selectedPosition == PositionType.Depot_Manager ||
                selectedPosition == PositionType.Depot_Worker)
            {
                cbDepartment.SelectedItem = Departments.warehouse;
                cbDepartment.Enabled = false;
                tbJobTitle.Text = cbPosition.SelectedItem.ToString();
            }
            else if (selectedPosition == PositionType.Sales_Manager ||
                selectedPosition == PositionType.Sales_Worker)
            {
                cbDepartment.SelectedItem = Departments.floorOne;
                cbDepartment.Enabled = true;
                tbJobTitle.Text = cbPosition.SelectedItem.ToString();
            }
            else
            {
                cbDepartment.Enabled = true;
                tbJobTitle.Enabled = true;
                tbJobTitle.Clear();
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            PositionType selectedPosition = (PositionType)cbPosition.SelectedItem;
            Departments selectedDepartment = (Departments)cbDepartment.SelectedItem;
            if ((selectedPosition == PositionType.Sales_Manager ||
               selectedPosition == PositionType.Sales_Worker) &&
               (selectedDepartment == Departments.office ||
               selectedDepartment == Departments.warehouse))
            {
                cbDepartment.SelectedItem = Departments.floorOne;
            }
        }
    }
}
