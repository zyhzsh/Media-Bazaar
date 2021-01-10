using System;
using System.Windows.Forms;

namespace Proj_Desktop_App.presentation
{
    public partial class DepartmentsForm : Form
    {
        private Department selectedDepartment;

        private int nrOfEmployees;
        private int nrOfProducts;

        private EmployeeStorage emplStorage;
        private ProductStorage prdStorage;
        private DepartmentStorage departments;

        private DepartmentCreateUpdateFrom departmentCUForm;

        public DepartmentsForm(EmployeeStorage emplStorage, ProductStorage prdStorage, DepartmentStorage departments)
        {
            InitializeComponent();
            this.emplStorage = emplStorage;
            this.prdStorage = prdStorage;
            this.departments = departments;

            cbDepartment.Items.AddRange(this.departments.GetDepartments());
            cbDepartment.SelectedIndex = 0;

            departmentCUForm = null;
        }

        private void UpdateGUI()
        {
            // Load all employees into list view
            Employee[] employees = emplStorage.GetEmployees(selectedDepartment);
            this.nrOfEmployees = employees.Length;
            lblNrOfEmployees.Text = nrOfEmployees.ToString();
            lvEmployees.Items.Clear();
            if (employees.Length == 0) { lvEmployees.Enabled = false; }
            else { lvEmployees.Enabled = true; }
            foreach (Employee employee in employees)
            {
                ListViewItem item = new ListViewItem(employee.GetBSN().ToString());
                string[] subitems = new string[] { employee.firstName, employee.lastName, employee.GetPosition().ToString() };
                item.SubItems.AddRange(subitems);
                lvEmployees.Items.Add(item);
            }

            // Load all products into list view
            Product[] products = prdStorage.ProductsByFloor(selectedDepartment);
            this.nrOfProducts = products.Length;
            lblNrOfProducts.Text = nrOfProducts.ToString();
            lvProducts.Items.Clear();
            if (products.Length == 0) { lvProducts.Enabled = false; }
            else { lvProducts.Enabled = true; }
            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem(product.id.ToString());
                string[] subitems = new string[] { product.Name, product.Brand };
                item.SubItems.AddRange(subitems);
                lvProducts.Items.Add(item);
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDepartment = (Department)cbDepartment.SelectedItem;
            UpdateGUI();
        }

        private void DepartmentCUForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateGUI();
            cbDepartment.Items.Clear();
            cbDepartment.Items.AddRange(this.departments.GetDepartments());
            try
            {
                cbDepartment.SelectedItem = selectedDepartment;
            }
            catch (Exception)
            {
                cbDepartment.SelectedIndex = 0;
            }
            departmentCUForm = null;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            // Open form for adding a department
            departmentCUForm = new DepartmentCreateUpdateFrom(departments);
            departmentCUForm.FormClosed += DepartmentCUForm_FormClosed;
        }


        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            if (selectedDepartment != null)
            {
                // Open form for editing a department
                bool hasProducts = false;
                if (nrOfProducts > 0) { hasProducts = true; }
                departmentCUForm = new DepartmentCreateUpdateFrom(departments, selectedDepartment, hasProducts);
                departmentCUForm.FormClosed += DepartmentCUForm_FormClosed;
            }
            else
            {
                MessageBox.Show("Please select a department.");
            }
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (selectedDepartment != null)
            {
                if (nrOfEmployees == 0 && nrOfProducts == 0)
                {
                    string confirmQuestion = "Are you sure you want to remove this department?";
                    DialogResult confirmResult = MessageBox.Show(confirmQuestion, "Confirm delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        departments.RemoveDepartment(selectedDepartment.Id);
                        cbDepartment.Items.Clear();
                        cbDepartment.Items.AddRange(this.departments.GetDepartments());
                        cbDepartment.SelectedIndex = 0;
                        UpdateGUI();
                    }
                }
                else
                {
                    string message = "You can't remove this department because it contains employees/products.";
                    MessageBox.Show(message, "Action not possible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a department.");
            }
        }

    }
}
