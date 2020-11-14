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
        private ProductStorage prdStorage;
        public ProductCRUDForm(ProductStorage prdStorage)
        {
            InitializeComponent();
            this.prdStorage = prdStorage;
            ReloadProducts();
        }

        public void ReloadProducts()
        {
            lbProducts.Items.Clear();
            foreach (Product p in prdStorage.Products)
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
                MessageBox.Show("No products have been selected");
            }
            else
            {
                ProductAddUpdateForm addProd = new ProductAddUpdateForm(this, prdStorage, (Product)lbProducts.SelectedItem);
                addProd.Show(this);
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
                    prdStorage.Remove(p.id);
                }
                ReloadProducts();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductAddUpdateForm addProd = new ProductAddUpdateForm(this, prdStorage);
            addProd.Show(this);
        }

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            ReloadProducts();
        }
    }
}
