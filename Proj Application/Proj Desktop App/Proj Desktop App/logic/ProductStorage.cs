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

        /// <summary>
        /// gets all products currently stored
        /// </summary>
        public Product[] Products { get { return this.products.ToArray(); } }
        public ProductStorage()
        {
            products = new List<Product>();
            prdMan = new ProductManagement();
            LoadProducts();
        }
        ///<summary>
        ///Reloads products from the database into storage
        ///</summary>
        private void LoadProducts()
        {
            products.Clear();
            foreach (Product p in prdMan.GetAllProducts())
            {
                products.Add(p);
            }
        }

        public Product GetProductById(int id)
        {
            foreach(Product p in products)
            {
                if(p.id == id)
                {
                    return p;
                }
            }
            return null;
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

        /// <summary>
        /// Add product without description
        /// </summary>
        public void Add(Departments belongingDepartment, string productName, string productBrand, double bought_price, double sold_price)
        {
            prdMan.AddProduct(belongingDepartment, productName, productBrand, bought_price, sold_price);
            LoadProducts();
        }

        /// <summary>
        /// Add product with description
        /// </summary>
        public void Add(Departments belongingDepartment, string productName, string productBrand, double bought_price, double sold_price, string description)
        {
            prdMan.AddProduct(belongingDepartment, productName, productBrand, bought_price, sold_price, description);
            LoadProducts();
        }


        /// <summary>
        /// remove product with id
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            Product p = GetProductById(id);
            if (p != null)
            {
                products.Remove(p);
                prdMan.RemoveProduct(id);
            }
        }

        /// <summary>
        /// Update product without description
        /// </summary>
        public void Update(Product productToUpdate, Departments department, string productName, string productBrand, double bought_price, double sold_price)
        {
            prdMan.UpdateProduct(productToUpdate.id, department, productName, productBrand, bought_price, sold_price);
            productToUpdate.Update(productName, productBrand, bought_price, sold_price, department);
        }
        /// <summary>
        /// Update product with description
        /// </summary>
        public void Update(Product productToUpdate, Departments department, string productName, string productBrand, double bought_price, double sold_price, string description)
        {
            prdMan.UpdateProduct(productToUpdate.id, department, productName, productBrand, bought_price, sold_price, description);
            productToUpdate.Update(productName, productBrand, bought_price, sold_price, department, description);
        }

    }
}
