using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // TO DO:
            // Load all employees into list view
            Employee[] employees = emplStorage.GetEmployees(selectedDepartment);
            this.nrOfEmployees = employees.Length;
            lblNrOfEmployees.Text = nrOfEmployees.ToString();

            // Load all products into list view
            Product[] products = prdStorage.ProductsByFloor(selectedDepartment);
            this.nrOfProducts = products.Length;
            lblNrOfProducts.Text = nrOfProducts.ToString();
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDepartment = (Department)cbDepartment.SelectedItem;
            UpdateGUI();
        }

        private void DepartmentCUForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateGUI();
            cbDepartment.Items.AddRange(this.departments.GetDepartments());
            cbDepartment.SelectedIndex = 0;
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
                    MessageBox.Show("You can't remove this department because it contains employees/products.");
                }
            }
            else
            {
                MessageBox.Show("Please select a department.");
            }
        }

    }
}
