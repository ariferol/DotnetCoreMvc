using System.Collections.Generic;
using System.Linq;
using EntitiesLayer.Context;
using EntitiesLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace RepositoriesLayer.AdoNet
{
    public class ProductRepositoryEF : IProductRepository
    {
        private readonly NorthwindContext _northwindDbContext;
        public ProductRepositoryEF(NorthwindContext context)
        {
            this._northwindDbContext = context;
        }

        public Products Find(int? id)
        {
            Products result;

            result = _northwindDbContext.Products.Find(id);

            return result;
        }

        public List<Products> GetProducts()
        {
            List<Products> result;
    
            var products = _northwindDbContext.Products; // define query
            foreach (var product in products) // query executed and data obtained from database
            {
                Categories prCategori = product.Category;
            }

            result = _northwindDbContext.Products.ToList();
            
            return result;
        }

        public List<Products> GetProductsByName(string productName)
        {
            List<Products> result;

            IEnumerable<Products> products = new List<Products>();
            if (!string.IsNullOrWhiteSpace(productName))
                products = _northwindDbContext.Products.Where(x => x.ProductName.ToLower().Contains(productName.ToLower()));

            result = products.ToList();

            return result;
        }

        public List<Categories> GetCategories()
        {
            List<Categories> result;
            IEnumerable<Categories> categories = from c in _northwindDbContext.Categories
                                                   orderby c.CategoryName
                                                   select c;
            result = categories.ToList();

            return result;
        }

        public List<Suppliers> GetSuppliers()
        {
            List<Suppliers> result;
            IEnumerable<Suppliers> suppliers = from s in _northwindDbContext.Suppliers
                                                orderby s.CompanyName
                                                select s;
            result = suppliers.ToList();

            return result;
        }

        public int CreateProduct(Products product)
        {
            int result;

            _northwindDbContext.Products.Add(product);
            result = _northwindDbContext.SaveChanges();

            return result;
        }

        public int UpdateProduct(Products product)
        {
            int result;
            _northwindDbContext.Entry(product).State = EntityState.Modified;
            result = _northwindDbContext.SaveChanges();

            return result;
        }

        public int DeleteProduct(int id)
        {
            int result;
            Products product = _northwindDbContext.Products.Find(id);
            if (product != null)
            {
                _northwindDbContext.Products.Remove(product);
                result = _northwindDbContext.SaveChanges();
            }
            else
                result = -1;                

            return result;
        }

        public List<ProductCategoryGroup> GetStats()
        {
            List<ProductCategoryGroup> result;

            IEnumerable<ProductCategoryGroup> 
                    productCategoryGroups = 
                    from product in _northwindDbContext.Products
                        join category in _northwindDbContext.Categories
                        on product.CategoryId equals category.CategoryId
                        group product by category.CategoryName into g
                        select new ProductCategoryGroup()
                        {
                            Category = g.Key,
                            ProductCount = g.Count()
                        };

               result = productCategoryGroups.ToList();
            
            return result;
        }

    }
}
