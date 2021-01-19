using System;
using System.Drawing;
using System.Windows.Forms;
using Proj_Desktop_App.logic;

namespace Proj_Desktop_App
{
    public partial class AdminForm : Form
    {
        private EmployeeStorage emplStorage;
        private Employee selectedEmployee;

        private ContractUpdateForm contrUForm;
        private EmployeeCreateUpdateForm emplCUForm;

        private DepartmentStorage departments;

        private ListViewColumnSorter lvwColumnSorter;

        public AdminForm(EmployeeStorage emplStorage, DepartmentStorage departments)
        {
            InitializeComponent();
            this.departments = departments;
            this.emplStorage = emplStorage;
            lvwColumnSorter = new ListViewColumnSorter();
            this.lvwEmployees.ListViewItemSorter = lvwColumnSorter;

            cbShowEmployed.Checked = true;
            selectedEmployee = null;
            cbSearchBy.Items.AddRange(new string[] { "Name", "BSN" });
            cbSearchBy.SelectedIndex = 0;
            emplCUForm = null;
            contrUForm = null;

            this.lvwColumnSorter.SortType = typeof(int);
            this.lvwEmployees.Columns[0].Text += "▲";
            this.lvwEmployees.Sort();
        }

        private void EmplCUForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateEmployees(false);
            emplCUForm = null;
        }

        private void ContrUForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadContracts();
            contrUForm = null;
        }

        private void cbShowEmployed_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEmployees(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateEmployees(true);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateEmployees(false);
        }

        /// <summary>
        /// Update the listbox of employees
        /// </summary>
        private void UpdateEmployees(bool searching)
        {
            Employee[] employees = null;

            if (searching)
            {
                string searchBy = cbSearchBy.SelectedItem.ToString();
                if (searchBy == "Name")
                {
                    employees = emplStorage.GetEmployees(cbShowEmployed.Checked, tbSearch.Text);
                }
                else if (searchBy == "BSN")
                {
                    try
                    {
                        employees = emplStorage.GetEmployees(cbShowEmployed.Checked, Convert.ToInt32(tbSearch.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please input only numbers to search by BSN");
                        return;
                    }
                }
            }
            else
            {
                employees = emplStorage.GetEmployees(cbShowEmployed.Checked);
            }

            // Load employees into listbox

            ListViewItem selectedItem;
            if (lvwEmployees.SelectedItems.Count > 0)
            {
                selectedItem = lvwEmployees.SelectedItems[0];
            }
            else
            {
                selectedItem = null;
            }

            lvwEmployees.Items.Clear();
            
            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem(employee.GetBSN().ToString());
                item.SubItems.Add(employee.firstName);
                item.SubItems.Add(employee.lastName);
                item.SubItems.Add(employee.contactEmail);

                lvwEmployees.Items.Add(item);
            }
            
            lblTotal.Text = employees.Length.ToString();

            if (selectedItem != null && lvwEmployees.Items.Contains(selectedItem))
            {
                int index = lvwEmployees.Items.IndexOf(selectedItem);
                lvwEmployees.Items[index].Selected = true;
            }
            else if (employees.Length > 0)
            {
                lvwEmployees.Items[0].Selected = true;
                lvwEmployees.Items.Contains(selectedItem);

            }
        }

        /// <summary>
        /// Display all contracts of an employee
        /// </summary>
        private void LoadContracts()
        {
            lvContracts.Items.Clear();
            Contract[] contracts = selectedEmployee.GetContracts();
            foreach (Contract contract in contracts)
            {
                ListViewItem item = new ListViewItem(contract.Iteration.ToString());
                lvContracts.Items.Add(item);
                string[] subitems = contract.ToString().Split(',');
                item.SubItems.AddRange(subitems);

                // Indicate if contract is active
                Color isActive = Color.Salmon;
                if (contract.IsActive())
                {
                    isActive = Color.LightGreen;
                }

                // Indicate if contract will end soon
                if (contract.IsCloseToEndDate())
                {
                    isActive = Color.SandyBrown;
                    item.SubItems[2].Text += '*';
                }
                item.BackColor = isActive;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Open form for creating a new employee
            emplCUForm = new EmployeeCreateUpdateForm(emplStorage, departments);
            emplCUForm.FormClosed += EmplCUForm_FormClosed;
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            if (selectedEmployee != null)
            {
                // Open form for updating an employee's details
                emplCUForm = new EmployeeCreateUpdateForm(emplStorage, selectedEmployee, departments);
                emplCUForm.FormClosed += EmplCUForm_FormClosed;
            }
            else
            {
                MessageBox.Show("Please select an employee form the list.");
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            if (selectedEmployee != null)
            {
                Contract activeContract = selectedEmployee.GetActiveContract();
                if (activeContract != null)
                {
                    // Open form for promotiing
                    contrUForm = new ContractUpdateForm(selectedEmployee, activeContract, ContractAction.Promote, departments);
                    contrUForm.FormClosed += ContrUForm_FormClosed;
                }
                else
                {
                    MessageBox.Show("This employee deosn't have an active contract.");
                }
            }
            else
            {
                MessageBox.Show("Please select an employee form the list.");
            }
        }

        private void btnExtendCon_Click(object sender, EventArgs e)
        {
            if (selectedEmployee != null)
            {
                Contract activeContract = selectedEmployee.GetActiveContract();
                Contract latestContract = selectedEmployee.GetLatestContract();
                if (activeContract == latestContract || (activeContract == null && latestContract != null))
                {
                    if (latestContract != null)
                    {
                        // Open form for extending a contract
                        contrUForm = new ContractUpdateForm(selectedEmployee, latestContract, ContractAction.Extend, departments);
                        contrUForm.FormClosed += ContrUForm_FormClosed;
                    }
                    else
                    {
                        MessageBox.Show("This employee doen't have a contract to extend.");
                    }
                }
                else
                {
                    MessageBox.Show("This employee already has an extention to their active contract.");
                }
            }
            else
            {
                MessageBox.Show("Please select an employee form the list.");
            }
        }

        private void btnTerminateCon_Click(object sender, EventArgs e)
        {
            if (selectedEmployee != null)
            {
                Contract activeContract = selectedEmployee.GetActiveContract();
                if (activeContract != null)
                {
                    // Open form for terminating a contarct
                    contrUForm = new ContractUpdateForm(selectedEmployee, activeContract, ContractAction.Terminate, departments);
                    contrUForm.FormClosed += ContrUForm_FormClosed;
                }
                else
                {
                    MessageBox.Show("This employee deosn't have an active contract.");
                }
            }
            else
            {
                MessageBox.Show("Please select an employee form the list.");
            }
        }

        private void lvwEmployees_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader columnToSort = lvwEmployees.Columns[e.Column];

            // Determine if clicked column is already the column that is being sorted.
            if (columnToSort.Index == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                columnToSort.Text = columnToSort.Text.Trim(new char[] { '▲', '▼' });
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                    columnToSort.Text += "▼";
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                    columnToSort.Text += "▲";
                }
            }
            else
            {
                // Set the column number that is to be sorted
                lvwColumnSorter.SortColumn = columnToSort.Index;
                foreach (ColumnHeader ch in lvwEmployees.Columns)
                {
                    ch.Text = ch.Text.Trim(new char[] { '▲', '▼' });
                }
                // Default sort order is ascending
                lvwColumnSorter.Order = SortOrder.Ascending;
                columnToSort.Text += "▲";
            }

            // Set the type of the column
            switch (e.Column)
            {
                case 0:
                    lvwColumnSorter.SortType = typeof(int);
                    break;
                default:
                    lvwColumnSorter.SortType = typeof(string);
                    break;
            }

            // Perform the sort with these new sort options.
            this.lvwEmployees.Sort();
        }

        private void lvwEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lbEmployees.Items.Count > 0)
            if (lvwEmployees.Items.Count > 0)
            {
                //selectedEmployee = (Employee)lbEmployees.SelectedItem;
                if (lvwEmployees.SelectedItems.Count > 0)
                {
                    int selectedBSN = Convert.ToInt32(lvwEmployees.SelectedItems[0].Text);
                    selectedEmployee = emplStorage.GetEmployee(selectedBSN);
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
                        LoadContracts();

                        // If employee isn't employed you can't update their details
                        btnUpdateDetails.Enabled = selectedEmployee.IsEmployed();
                    }
                }
            }
        }
    }
}
