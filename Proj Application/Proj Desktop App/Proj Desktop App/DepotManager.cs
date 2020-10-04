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
    public partial class DepotManager : Form
    {
        private Store mediabazaar;
        public DepotManager(Store form1Mediabazaar)
        {
            InitializeComponent();
            mediabazaar = form1Mediabazaar;
            ReloadProducts();
            ReloadRequests();
        }

        private void ReloadRequests()
        {
            lbIncomingRestocks.Items.Clear();
            foreach (RestockRequest request in mediabazaar.GetRestockRequests)
            {
                lbIncomingRestocks.Items.Add(request);
            }
        }

        private void ReloadProducts()
        {
            lbProducts.Items.Clear();
            foreach (Product p in mediabazaar.Products)
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
                ProductManagementForm addProd = new ProductManagementForm(mediabazaar, (Product)lbProducts.SelectedItem);
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
                    mediabazaar.RemoveProduct(p.Id);
                }
                ReloadProducts();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductManagementForm addProd = new ProductManagementForm(mediabazaar);
            addProd.Show(this);
            ReloadProducts();
        }

        private void btnAcceptRestock_Click(object sender, EventArgs e)
        {
            if (lbIncomingRestocks.SelectedItems.Count <= 0)
            {
                MessageBox.Show("No restocks selected");
            }
            else
            {
                for (int i = lbIncomingRestocks.SelectedItems.Count - 1; i >= 0; i--)
                {
                    mediabazaar.AcceptRestock((RestockRequest)lbIncomingRestocks.SelectedItems[i]);
                }
            }
            ReloadRequests();
        }

        private void btnRejectRestock_Click(object sender, EventArgs e)
        {
            for (int i = lbIncomingRestocks.SelectedItems.Count - 1; i >= 0; i--)
            {
                int requestID = ((RestockRequest) lbIncomingRestocks.SelectedItems[i]).GetProductId;
                mediabazaar.RemoveRestock(requestID);
            }
            ReloadRequests();
        }

        private void btnDepotRefresh_Click(object sender, EventArgs e)
        {
            ReloadRequests();
            ReloadProducts();
        }
    }
}
