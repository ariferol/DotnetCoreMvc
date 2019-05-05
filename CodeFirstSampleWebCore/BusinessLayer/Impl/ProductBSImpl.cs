using EntitiesLayer.Models;
using RepositoriesLayer;
using System.Collections.Generic;

namespace BusinessLayer.Impl
{
    public class ProductBSImpl : IProductBS
    {
        private readonly IProductRepository _productRepository;

        public ProductBSImpl(IProductRepository pRepository)
        {
            this._productRepository = pRepository;
        }

        public List<Products> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public Products Find(int? id)
        {
            return _productRepository.Find(id);
        }

        public List<Categories> GetCategories()
        {
            return _productRepository.GetCategories();
        }

        public List<Suppliers> GetSuppliers()
        {
            return _productRepository.GetSuppliers();
        }

        public int CreateProduct(Products product)
        {
            return _productRepository.CreateProduct(product);
        }

        public int UpdateProduct(Products product)
        {
            return _productRepository.UpdateProduct(product);
        }

        public int DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public List<ProductCategoryGroup> GetStats()
        {
            return _productRepository.GetStats();
        }

        public List<Products> GetProductsByName(string productName)
        {
            return _productRepository.GetProductsByName(productName);
        }

    }
}
