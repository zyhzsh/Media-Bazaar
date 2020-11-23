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
        public ProductAddUpdateForm(ProductCRUDForm crudForm, ProductStorage prdStorage)
        {
            InitializeComponent();
            this.crudForm = crudForm;
            this.prdStorage = prdStorage;

            this.Text = "Add product";
            btnConfirm.Text = "Add";
        }

        public ProductAddUpdateForm(ProductCRUDForm crudForm, ProductStorage prdStorage, Product editProduct)
        {
            InitializeComponent();
            this.crudForm = crudForm;
            this.prdStorage = prdStorage;
            updateProduct = editProduct;


            tbProductName.Text = editProduct.Name;
            tbBrand.Text = editProduct.Brand;
            numBuyingPrice.Value = (decimal)editProduct.BoughtPrice;
            numSellingPrice.Value = (decimal)editProduct.SoldPrice;
            cbDepartment.SelectedIndex = ((int)(editProduct.Department)) - 1;


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
                Departments department = DepartmentFromString(cbDepartment.SelectedItem.ToString().Trim());
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
        private Departments DepartmentFromString(string departmentString)
        {
            Departments department;
            switch (departmentString)
            {
                case "Floor 1":
                    department = Departments.floorOne;
                    break;
                case "Floor 2":
                    department = Departments.floorTwo;
                    break;
                case "Floor 3":
                    department = Departments.floorThree;
                    break;
                case "Floor 4":
                    department = Departments.floorFour;
                    break;
                default:
                    department = Departments.floorOne;
                    break;
            }
            return department;
        }
    }
}
