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
    public partial class EmployeeCreateUpdateForm : Form
    {
        // Store
        private EmployeeStorage store;
        private DepartmentStorage departmentStorage;

        // For updating employee details
        private bool updateEmployee;
        private Employee employeeToUpdate;

        private void InitializeElements()
        {
            this.Visible = true;
            cbPosition.DataSource = Enum.GetValues(typeof(PositionType));
            cbDepartment.Items.AddRange(departmentStorage.GetDepartments());
        }

        /// <summary>
        /// Adding a new employee
        /// </summary>
        public EmployeeCreateUpdateForm(EmployeeStorage store, DepartmentStorage departments)
        {
            InitializeComponent();
            this.departmentStorage = departments;
            InitializeElements();
            this.store = store;
            updateEmployee = false;
            Text = "New Employee Form";
            btnConfirm.Text = "Add employee";
            rbMale.Checked = true;
            dtpStartDate.MinDate = DateTime.Today;
            dtpBirthdate.MaxDate = DateTime.Today.AddYears(-16);
        }

        /// <summary>
        /// Updating employee details
        /// </summary>
        public EmployeeCreateUpdateForm(EmployeeStorage store, Employee employee, DepartmentStorage departments)
        {
            InitializeComponent();
            this.departmentStorage = departments;
            InitializeElements();
            this.store = store;
            updateEmployee = true;

            // Fill in with current employee data
            employeeToUpdate = employee;

            tbBSN.Text = employeeToUpdate.GetBSN().ToString();
            tbFirstName.Text = employeeToUpdate.firstName;
            tbLastName.Text = employeeToUpdate.lastName;
            if (employeeToUpdate.gender == 'M') { rbMale.Checked = true; }
            else if (employeeToUpdate.gender == 'F') { rbFemale.Checked = true; }
            else { rbOther.Checked = true; }
            dtpBirthdate.Value = employeeToUpdate.birthDate;
            tbLanguages.Text = employeeToUpdate.languages;
            tbCertificates.Text = employeeToUpdate.certificates;

            tbPhone.Text = employeeToUpdate.phoneNumber;
            tbAddress.Text = employeeToUpdate.address;
            tbEmail.Text = employeeToUpdate.contactEmail;

            try
            {
                cbPosition.SelectedItem = employeeToUpdate.GetPosition();
                cbDepartment.SelectedItem = departmentStorage.GetDepartment(employeeToUpdate.GetDepartment().Id);
                nudFTE.Value = Convert.ToDecimal(employeeToUpdate.GetFTE());
            }
            catch(Exception)
            {
                this.Close();
                MessageBox.Show("Something went wrong!");
            }

            // Can"t be changed
            tbBSN.Enabled = false;
            dtpBirthdate.Enabled = false;
            dtpStartDate.Enabled = false;
            nudDuration.Enabled = false;
            cbPosition.Enabled = false;
            cbDepartment.Enabled = false;
            nudFTE.Enabled = false;
            btnConfirm.Text = "Save changes";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;

            string languages = tbLanguages.Text;
            string certificates = tbCertificates.Text;

            string phone = tbPhone.Text;
            string address = tbAddress.Text;
            string email = tbEmail.Text;

            // Check string inputs
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                    string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all employee data.");
            }
            else
            {
                char gender;
                if (rbMale.Checked) { gender = 'M'; }
                else if (rbFemale.Checked) { gender = 'F'; }
                else { gender = 'O'; }

                if (!updateEmployee)
                {
                    try
                    {
                        int bsn = Convert.ToInt32(tbBSN.Text);
                        DateTime birthdate = dtpBirthdate.Value;

                        DateTime startDate = dtpStartDate.Value;
                        int duration = Convert.ToInt32(nudDuration.Value);
                        DateTime endDate = startDate.AddMonths(duration);
                        PositionType position = (PositionType)cbPosition.SelectedItem;
                        Department department = (Department)cbDepartment.SelectedItem;
                        decimal fte = nudFTE.Value;

                        // Add new employee
                        try
                        {
                            store.AddEmployee(bsn, firstName, lastName, gender, birthdate, languages, certificates,
                                                  phone, address, email, startDate, endDate, position, department, fte);
                            this.Close();
                            
                        }
                        catch (Exception ex)
                        {
                            // Database error
                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please input a valid BSN.");
                    }

                }
                else
                {
                    // Update employee
                    try
                    {
                        employeeToUpdate.UpdateInfo(firstName, lastName, gender, languages, certificates,
                            phone, address, email);
                    }
                    catch (Exception ex)
                    {
                        // Database error
                        MessageBox.Show(ex.Message);
                    }
                    this.Close();
                }
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

        // - - - - - - - - - - - - - - - - - - - - - - //
        // Managing the position and department inputs //
        // - - - - - - - - - - - - - - - - - - - - - - //

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PositionType selectedPosition = (PositionType)cbPosition.SelectedItem;
                switch (selectedPosition)
                {
                    case PositionType.Administrator:
                        cbDepartment.SelectedItem = departmentStorage.GetDepartment(6); // HR
                        cbDepartment.Enabled = false;
                        break;

                    case PositionType.Depot_Manager:
                    case PositionType.Depot_Worker:
                        cbDepartment.SelectedItem = departmentStorage.GetDepartment(5); // Warehouse
                        cbDepartment.Enabled = false;
                        break;

                    case PositionType.Sales_Manager:
                    case PositionType.Sales_Worker:
                        cbDepartment.SelectedItem = departmentStorage.GetDepartment(1); // Floor one
                        cbDepartment.Enabled = true;
                        break;

                    default:
                        cbDepartment.Enabled = true;
                        break;
                }
            }
            catch (Exception)
            {
                cbDepartment.Enabled = true;
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object position = cbPosition.SelectedItem;
                if (position != null)
                {
                    PositionType selectedPosition = (PositionType)position;
                    Department selectedDepartment = (Department)cbDepartment.SelectedItem;
                    if ((selectedPosition == PositionType.Sales_Manager ||
                       selectedPosition == PositionType.Sales_Worker) &&
                       (selectedDepartment == departmentStorage.GetDepartment(6) || // HR
                       selectedDepartment == departmentStorage.GetDepartment(5))) // Warehouse
                    {
                        cbDepartment.SelectedItem = departmentStorage.GetDepartment(1); // Floor one
                    }
                }
            }
            catch (Exception)
            {
                cbDepartment.Enabled = true;
            }
        }
    }
}
