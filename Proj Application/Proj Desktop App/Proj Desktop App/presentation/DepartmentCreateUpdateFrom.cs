using System;
using System.Windows.Forms;

namespace Proj_Desktop_App.presentation
{
    public partial class DepartmentCreateUpdateFrom : Form
    {
        private bool updateDepartment;

        private DepartmentStorage departments;
        private Department departmentToUpdate;

        // Adding a department
        public DepartmentCreateUpdateFrom(DepartmentStorage departments)
        {
            InitializeComponent();
            this.Visible = true;
            this.Text = "Add department";
            gbDepartment.Text = "Add department";
            updateDepartment = false;

            this.departments = departments;

            tbId.Text = "auto";
        }

        // Editing a department
        public DepartmentCreateUpdateFrom(DepartmentStorage departments, Department departmentToUpdate, bool hasProducts)
        {
            InitializeComponent();
            this.Visible = true;
            this.Text = "Edit department";
            gbDepartment.Text = "Edit department";
            updateDepartment = true;

            this.departments = departments;
            this.departmentToUpdate = departmentToUpdate;

            tbId.Text = departmentToUpdate.Id.ToString();
            tbName.Text = departmentToUpdate.Name.ToString();
            cbSellsProducts.Checked = departmentToUpdate.SellsProducts;
            if (hasProducts) { cbSellsProducts.Enabled = false; }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a department name.");
            }
            else
            {
                bool sellsProducts = cbSellsProducts.Checked;

                if (!updateDepartment)
                {
                    // Adding a department
                    try
                    {
                        departments.AddDepartment(name, sellsProducts);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Database error
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    // Editing a department
                    try
                    {
                        departments.UpdateDepartment(departmentToUpdate.Id, name, sellsProducts);
                    }
                    catch (Exception ex)
                    {
                        // Database error
                        MessageBox.Show(ex.Message);
                    }
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
    }
}
