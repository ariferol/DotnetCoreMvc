using EntitiesLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IProductBS
    {
        List<Products> GetProducts();

        Products Find(int? id);

        List<Categories> GetCategories();

        List<Suppliers> GetSuppliers();

        int CreateProduct(Products product);

        int UpdateProduct(Products product);

        int DeleteProduct(int id);

        List<ProductCategoryGroup> GetStats();

        List<Products> GetProductsByName(string productName);
    }
}
