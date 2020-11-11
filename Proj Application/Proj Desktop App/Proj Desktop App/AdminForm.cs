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
    public partial class AdminForm : Form
    {
        private Store store;
        private Employee selectedEmployee;

        public AdminForm(Store store)
        {
            InitializeComponent();
            this.store = store;
            store.EmployeeChanged += Store_EmployeeChanged;
            cbShowEmployed.Checked = true;
            cbSearchBy.SelectedIndex = 0;
            selectedEmployee = null;
            UpdateEmployees(false);
        }

        private void Store_EmployeeChanged(Employee employee)
        {
            UpdateEmployees(false);
            if (lbEmployees.Items.Count > 0)
            {
                lbEmployees.SelectedItem = employee;
            }
        }

        public void UpdateEmployees(bool searching)
        {
            Employee[] employees;

            if (searching)
            {
                bool searchByString = true;
                if (cbSearchBy.SelectedItem.ToString() == "BSN")
                {
                    searchByString = false;
                }

                if (cbShowEmployed.Checked)
                {
                    if (searchByString)
                    {
                        employees = store.GetEmployees(true, tbSearch.Text);
                    }
                    else
                    {
                        employees = store.GetEmployees(true, Convert.ToInt32(tbSearch.Text));
                    }
                }
                else
                {
                    if (searchByString)
                    {
                        employees = store.GetEmployees(tbSearch.Text);
                    }
                    else
                    {
                        employees = store.GetEmployees(Convert.ToInt32(tbSearch.Text));
                    }
                }
            }
            else
            {
                if (cbShowEmployed.Checked)
                {
                    employees = store.GetEmployees(true);
                }
                else
                {
                    employees = store.GetEmployees();
                }
            }

            // Load employees into listbox
            lbEmployees.Items.Clear();
            lbEmployees.Items.AddRange(employees);
            lblTotal.Text = employees.Length.ToString();

            if (selectedEmployee != null && lbEmployees.Items.Contains(selectedEmployee))
            {
                lbEmployees.SelectedIndex = lbEmployees.Items.IndexOf(selectedEmployee);
            }
            else
            {
                lbEmployees.SelectedIndex = 0;
            }
        }

        private void cbShowEmployed_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEmployees(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateEmployees(true);
        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployees.Items.Count > 0)
            {
                selectedEmployee = (Employee)lbEmployees.SelectedItem;
                if (selectedEmployee != null)
                {
                    // Show employee details:
                    lblNames.Text = $"{selectedEmployee.firstName} {selectedEmployee.lastName}";
                    lblBSN.Text = selectedEmployee.GetBSN().ToString();
                    lblGender.Text = selectedEmployee.gender.ToString();
                    lblBirthdate.Text = selectedEmployee.birthDate.ToString("dd/MM/yyyy");
                    lblLanguages.Text = selectedEmployee.languages;
                    lblCertificates.Text = selectedEmployee.certificates;
                    lblPhone.Text = selectedEmployee.phoneNumber;
                    lblEmail.Text = selectedEmployee.contactEmail;
                    lblAddress.Text = selectedEmployee.address;

                    // Show employee status:
                    bool employed = selectedEmployee.IsEmployed();
                    if (employed)
                    {
                        lblEmployed.Text = "employed";
                    }
                    else
                    {
                        lblEmployed.Text = "unemployed";
                    }

                    // Show employee contracts:
                    lvContracts.Items.Clear();
                    Contract[] contracts = selectedEmployee.GetContracts();
                    foreach (Contract contract in contracts)
                    {
                        ListViewItem item = new ListViewItem(contract.Iteration.ToString());
                        lvContracts.Items.Add(item);
                        string[] subitems = contract.ToString().Split(',');
                        item.SubItems.AddRange(subitems);
                        Color isActive = Color.Salmon;
                        if (contract.IsActive())
                        {
                            isActive = Color.LightGreen;
                        }
                        item.BackColor = isActive;
                    }

                    // If employee isn't employed you can't update their details
                    btnUpdateDetails.Enabled = selectedEmployee.IsEmployed();
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            new EmployeeCreateUpdateForm(store);
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            if (selectedEmployee != null)
            {
                EmployeeCreateUpdateForm updateForm = new EmployeeCreateUpdateForm(store, selectedEmployee);
            }
            else
            {
                MessageBox.Show("Please select an employee form the list.");
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnExtendCon_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnTerminateCon_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
