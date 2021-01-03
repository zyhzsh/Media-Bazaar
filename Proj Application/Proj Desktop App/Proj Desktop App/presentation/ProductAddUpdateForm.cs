using Proj_Desktop_App.dataAccess;
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
    public partial class ProductAddUpdateForm : Form
    {
        private ProductStorage prdStorage;
        private ProductCRUDForm crudForm;
        private Product updateProduct;
        private DepartmentStorage departmentStorage;
        
        public ProductAddUpdateForm(ProductCRUDForm crudForm, ProductStorage prdStorage, DepartmentStorage departments)
        {
            InitializeComponent();
            this.crudForm = crudForm;
            this.prdStorage = prdStorage;
            this.departmentStorage = departments;

            this.Text = "Add product";
            btnConfirm.Text = "Add";

            cbDepartment.Items.AddRange(departmentStorage.GetSellingDepartments());
            cbDepartment.SelectedIndex = 0;
        }

        public ProductAddUpdateForm(ProductCRUDForm crudForm, ProductStorage prdStorage, Product editProduct, DepartmentStorage departments)
        {
            InitializeComponent();
            this.crudForm = crudForm;
            this.prdStorage = prdStorage;
            this.departmentStorage = departments;
            updateProduct = editProduct;


            tbProductName.Text = editProduct.Name;
            tbBrand.Text = editProduct.Brand;
            numBuyingPrice.Value = (decimal)editProduct.BoughtPrice;
            numSellingPrice.Value = (decimal)editProduct.SoldPrice;
            cbDepartment.Items.AddRange(departmentStorage.GetSellingDepartments());
            cbDepartment.SelectedItem = departmentStorage.GetDepartment(editProduct.Department.Id);


            this.Text = "Update product";
            btnConfirm.Text = "Update";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProductName.Text) || string.IsNullOrWhiteSpace(tbBrand.Text)
            || cbDepartment.SelectedItem == null || numBuyingPrice.Value <= 0 || numSellingPrice.Value <= 0)
            {
                MessageBox.Show("One or more fields have not been filled in properly");
            }
            else
            {
                Department department = (Department)cbDepartment.SelectedItem;
                double buy = (double)Math.Round(numBuyingPrice.Value, 2);
                double sell = (double)Math.Round(numSellingPrice.Value, 2);
                if (btnConfirm.Text == "Add")
                {
                    
                    if (string.IsNullOrEmpty(rtbDescription.Text))
                    {
                        prdStorage.Add(department, tbProductName.Text, tbBrand.Text, buy, sell);
                    }
                    else
                    {
                        prdStorage.Add(department, tbProductName.Text, tbBrand.Text, buy, sell, rtbDescription.Text);
                    }
                    this.crudForm.ReloadProducts();
                    MessageBox.Show("Product added");
                    Close();
                }
                else if (btnConfirm.Text == "Update")
                {
                    if (string.IsNullOrEmpty(rtbDescription.Text))
                    {
                        prdStorage.Update(updateProduct, department, tbProductName.Text, tbBrand.Text, buy, sell);
                    }
                    else
                    {
                        prdStorage.Update(updateProduct, department, tbProductName.Text, tbBrand.Text, buy, sell, rtbDescription.Text);
                    }
                    this.crudForm.ReloadProducts();
                    MessageBox.Show("Product updated");
                    Close();
                }
            }
        }
    }
}
