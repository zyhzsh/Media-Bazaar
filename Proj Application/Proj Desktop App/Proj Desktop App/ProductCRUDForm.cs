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
    public partial class ProductCRUDForm : Form
    {
        private ProcuctManagement dtbMan;
        public ProductCRUDForm()
        {
            InitializeComponent();
            dtbMan = new ProcuctManagement();
            ReloadProducts();
        }

        private void ReloadProducts()
        {
            lbProducts.Items.Clear();
            foreach (Product p in dtbMan.GetAllProducts())
            {
                lbProducts.Items.Add(p);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedItems.Count > 1)
            {
                MessageBox.Show("Cannot update multiple products simultaneously");
            }
            else if (lbProducts.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No products have been selectedS");
            }
            else
            {
                ProductManagementForm addProd = new ProductManagementForm((Product)lbProducts.SelectedItem);
                addProd.Show(this);
                ReloadProducts();
            }
        }

        private void btnRemProduct_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No products have been selected");
            }
            else
            {
                foreach (Product p in lbProducts.SelectedItems)
                {
                    dtbMan.RemoveProduct(p.id);
                }
                ReloadProducts();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductManagementForm addProd = new ProductManagementForm();
            addProd.Show(this);
            ReloadProducts();
        }

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            ReloadProducts();
        }
    }
}
