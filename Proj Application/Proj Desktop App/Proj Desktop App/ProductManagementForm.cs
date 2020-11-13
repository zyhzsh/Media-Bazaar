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
    public partial class ProductManagementForm : Form
    {
        private ProductManagement dtbMan;
        private int updateProduct;
        public ProductManagementForm()
        {
            InitializeComponent();
            dtbMan = new ProductManagement();
        }

        public ProductManagementForm(Product editProduct)
        {
            InitializeComponent();
            dtbMan = new ProductManagement();
            updateProduct = editProduct.id;
            tbProductName.Text = editProduct.Name;
            tbBrand.Text = editProduct.Brand;
            numBuyingPrice.Value = (decimal)editProduct.BuyingPrice;
            numSellingPrice.Value = (decimal)editProduct.SellingPrice;
            switch (editProduct.Department)
            {
                case Departments.floorOne:
                    cbDepartment.SelectedIndex = 0;
                    break;
                case Departments.floorTwo:
                    cbDepartment.SelectedIndex = 1;
                    break;
                case Departments.floorThree:
                    cbDepartment.SelectedIndex = 2;
                    break;
                case Departments.floorFour:
                    cbDepartment.SelectedIndex = 3;
                    break;
            }
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
                Departments department;
                switch (cbDepartment.SelectedItem.ToString().Trim())
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
                if (btnConfirm.Text == "Add")
                {
                    double sell = (double)Math.Round(numSellingPrice.Value, 2);
                    double buy = (double)Math.Round(numBuyingPrice.Value, 2);
                    if (string.IsNullOrEmpty(rtbDescription.Text))
                    {
                        dtbMan.AddProduct(department, tbProductName.Text, tbBrand.Text, sell, buy);
                    }
                    else
                    {
                        dtbMan.AddProduct(department, tbProductName.Text, tbBrand.Text, sell, buy, rtbDescription.Text);
                    }
                    
                    Close();
                }
                else if (btnConfirm.Text == "Update")
                {
                    if (string.IsNullOrEmpty(rtbDescription.Text))
                    {
                        dtbMan.UpdateProduct(updateProduct, department, tbProductName.Text, tbBrand.Text, (double)numSellingPrice.Value, (double)numBuyingPrice.Value);
                    }
                    else
                    {
                        dtbMan.UpdateProduct(updateProduct, department, tbProductName.Text, tbBrand.Text, (double)numSellingPrice.Value, (double)numBuyingPrice.Value, rtbDescription.Text);
                    }
                    MessageBox.Show("Product updated");
                    Close();
                }
            }
        }
    }
}
