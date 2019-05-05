using EntitiesLayer.Models;
using System.Collections.Generic;

namespace RepositoriesLayer
{
    public interface IProductRepository
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
