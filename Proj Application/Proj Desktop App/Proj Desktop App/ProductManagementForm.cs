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
        private Store mediabazaar;
        private Product updateProduct;
        public ProductManagementForm(Store DepoMngrMediaBazaar)
        {
            InitializeComponent();
            mediabazaar = DepoMngrMediaBazaar;
            this.Text = "Add new product";
            btnConfirm.Text = "Add";
        }

        public ProductManagementForm(Store DepoMngrMediaBazaar, Product editProduct)
        {
            InitializeComponent();
            mediabazaar = DepoMngrMediaBazaar;
            updateProduct = editProduct;
            tbProductName.Text = updateProduct.Name;
            tbBrand.Text = updateProduct.Brand;
            numBuyingPrice.Value = (decimal)updateProduct.BuyingPrice;
            numSellingPrice.Value = (decimal) updateProduct.SellingPrice;
            switch (updateProduct.Department)
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
                    mediabazaar.AddProduct(tbProductName.Text, tbBrand.Text, sell, buy, department);
                    Close();
                }
                else if (btnConfirm.Text == "Update")
                {
<<<<<<< HEAD
                    mediabazaar.UpdateProduct(updateProduct.id, tbProductName.Text,  tbBrand.Text, (double)numSellingPrice.Value, (double)numBuyingPrice.Value, department, rtbDescription.Text);
=======
                    mediabazaar.UpdateProduct(updateProduct.Id, tbProductName.Text,  tbBrand.Text, (double)numSellingPrice.Value, (double)numBuyingPrice.Value, department, rtbDescription.Text);
>>>>>>> website
                    MessageBox.Show("Product updated");
                    Close();
                }
            }
        }
    }
}
