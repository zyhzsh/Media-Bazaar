using System;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public partial class ProductCRUDForm : Form
    {
        private ProductStorage prdStorage;
        private DepartmentStorage departments;
        public ProductCRUDForm(ProductStorage prdStorage, DepartmentStorage departments)
        {
            InitializeComponent();
            this.prdStorage = prdStorage;
            this.departments = departments;
            ReloadProducts();
        }

        public void ReloadProducts()
        {
            lvProducts.Items.Clear();

            foreach (Product p in prdStorage.Products)
            {
                ListViewItem item = new ListViewItem(p.id.ToString());
                item.SubItems.Add(p.Name);
                item.SubItems.Add(p.Brand);
                item.SubItems.Add(p.Description);
                item.SubItems.Add(p.SoldPrice.ToString());
                item.SubItems.Add(p.BoughtPrice.ToString());
                item.SubItems.Add(p.Department.ToString());
                item.SubItems.Add(p.Stock.ToString());

                lvProducts.Items.Add(item);
            }

            foreach (ColumnHeader column in lvProducts.Columns)
            {
                if (column.Text == "Name" || column.Text == "Brand")
                {
                    column.Width = -1;
                }
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 1)
            {
                MessageBox.Show("Cannot update multiple products simultaneously");
            }
            else if (lvProducts.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No products have been selected");
            }
            else
            {
                ProductAddUpdateForm addProd = new ProductAddUpdateForm(this, prdStorage, InitializeProduct(lvProducts.SelectedItems[0]), departments);
                addProd.Show(this);
            }
        }

        private void btnRemProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No products have been selected");
            }
            else
            {
                foreach (ListViewItem item in lvProducts.SelectedItems)
                {
                    prdStorage.Remove(Convert.ToInt32(item.Text));
                }
                ReloadProducts();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductAddUpdateForm addProd = new ProductAddUpdateForm(this, prdStorage, departments);
            addProd.Show(this);
        }

        private void btnProductRefresh_Click(object sender, EventArgs e)
        {
            ReloadProducts();
        }

        private Product InitializeProduct(ListViewItem item)
        {
            Product prod = prdStorage.GetProductById(Convert.ToInt32(item.Text));
            return prod;
        }
    }
}
