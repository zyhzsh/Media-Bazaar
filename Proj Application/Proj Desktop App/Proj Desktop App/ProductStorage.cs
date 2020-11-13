using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj_Desktop_App.dataAccess;

namespace Proj_Desktop_App
{
    public class ProductStorage
    {
        private List<Product> products;
        private ProductManagement prdMan;

        public Product[] Products { get { return this.products.ToArray(); } }
        public ProductStorage()
        {
            products = new List<Product>();
            prdMan = new ProductManagement();
            LoadProducts();
        }
        ///<summary>
        ///Reloads products from the database
        ///</summary>
        private void LoadProducts()
        {
            products.Clear();
            foreach (Product p in prdMan.GetAllProducts())
            {
                products.Add(p);
            }
        }

        public Product[] ProductsByFloor(Departments dep)
        {
            List<Product> flooredProducts = new List<Product>();
            foreach(Product p in products)
            {
                if(p.Department == dep)
                {
                    flooredProducts.Add(p);
                }
            }
            return flooredProducts.ToArray();
        }

        
    }
}
