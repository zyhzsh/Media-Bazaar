using System;
using System.Windows.Forms;
using Proj_Desktop_App.logic;

namespace Proj_Desktop_App
{
    public partial class ProductCRUDForm : Form
    {
        private ProductStorage prdStorage;
        private DepartmentStorage departments;

        private ListViewColumnSorter lvwColumnSorter;

        public ProductCRUDForm(ProductStorage prdStorage, DepartmentStorage departments)
        {
            InitializeComponent();
            this.prdStorage = prdStorage;
            this.departments = departments;

            lvwColumnSorter = new ListViewColumnSorter();
            this.lvProducts.ListViewItemSorter = lvwColumnSorter;

            ReloadProducts();

            this.lvwColumnSorter.SortType = typeof(int);
            this.lvProducts.Columns[0].Text += "▲";
            this.lvProducts.Sort();
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

        private void lvProducts_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader columnToSort = lvProducts.Columns[e.Column];

            // Determine if clicked column is already the column that is being sorted.
            if (columnToSort.Index == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                columnToSort.Text = columnToSort.Text.Trim(new char[] { '▲', '▼' });
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                    columnToSort.Text += "▼";
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                    columnToSort.Text += "▲";
                }
            }
            else
            {
                // Set the column number that is to be sorted
                lvwColumnSorter.SortColumn = columnToSort.Index;
                foreach (ColumnHeader ch in lvProducts.Columns)
                {
                    ch.Text = ch.Text.Trim(new char[] { '▲', '▼' });
                }
                // Default sort order is ascending
                lvwColumnSorter.Order = SortOrder.Ascending;
                columnToSort.Text += "▲";
            }

            // Set the type of the column
            switch (e.Column)
            {
                case 0:
                case 7:
                    lvwColumnSorter.SortType = typeof(int);
                    break;
                case 4:
                case 5:
                    lvwColumnSorter.SortType = typeof(double);
                    break;
                default:
                    lvwColumnSorter.SortType = typeof(string);
                    break;
            }

            // Perform the sort with these new sort options.
            this.lvProducts.Sort();
        }
    }
}
