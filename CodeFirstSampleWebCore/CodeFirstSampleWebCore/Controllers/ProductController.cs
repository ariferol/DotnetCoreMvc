using System.Collections.Generic;
using System.Net;
using BusinessLayer;
using CodeFirstSampleWebCore.Models;
using EntitiesLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage;
using X.PagedList;

namespace CodeFirstSampleWebCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductBS _productService;

        public ProductController(IProductBS productBS)
        {
            this._productService = productBS;
        }

        // GET: Product
        public ActionResult Index(string pAdi, int? page)
        {
            List<Products> productsList = new List<Products>();
            if (string.IsNullOrEmpty(pAdi))
            {
                productsList = _productService.GetProducts();
            }
            else
            {
                productsList = _productService.GetProductsByName(pAdi);
            }
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ProductModel model = new ProductModel();
            model.Adi = pAdi;
            model.PagedList = productsList.ToPagedList(pageNumber, pageSize);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ProductModel model)
        {
            int page = 1;
            List<Products> productsList = new List<Products>();
            if (!string.IsNullOrEmpty(model.Adi))
            {
                page = 1;
                productsList = _productService.GetProductsByName(model.Adi);
            }

            int pageSize = 10;
            int pageNumber = 1;//(page ?? 1);
            model.PagedList = productsList.ToPagedList(pageNumber, pageSize);
            return View(model);
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return StatusCode(HttpStatusCode.BadRequest.GetHashCode());
            }
            Products product = _productService.Find(id);
            if (product == null)
            {
                return StatusCode(HttpStatusCode.NotFound.GetHashCode());
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            PopulateCategoryDropDownList();
            PopulateSupplierDropDownList();
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Products model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productService.CreateProduct(model);
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                // Log the error (uncomment dex variable name and add a line here to write a log.)
                ModelState.AddModelError("",
                    "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }

            PopulateCategoryDropDownList(model.CategoryId);
            PopulateSupplierDropDownList(model.SupplierId);
            return View(model);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return StatusCode(HttpStatusCode.BadRequest.GetHashCode());
            }
            Products product = _productService.Find(id);
            if (product == null)
            {
                return StatusCode(HttpStatusCode.NotFound.GetHashCode());
            }
            PopulateCategoryDropDownList(product.CategoryId);
            PopulateSupplierDropDownList(product.SupplierId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Products model)
        {
            if (ModelState.IsValid)
            {
                _productService.UpdateProduct(model);
                return RedirectToAction("Index");
            }
            PopulateCategoryDropDownList(model.CategoryId);
            PopulateSupplierDropDownList(model.SupplierId);
            return View(model);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return StatusCode(HttpStatusCode.BadRequest.GetHashCode());
            }
            Products product = _productService.Find(id);
            if (product == null)
            {
                return StatusCode(HttpStatusCode.NotFound.GetHashCode());
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _productService.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        // GET: Products/Stats
        // uses the ProductCategoryGroup ViewModel to represent product data 
        public ActionResult Stats(int? id)
        {
            List<ProductCategoryGroup> productCategories = _productService.GetStats();
            return View(productCategories);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        // -----------------------------------------------------------------------------
        // private parts

        private void PopulateCategoryDropDownList(object selectedCategory = null)
        {
            var categories = _productService.GetCategories();
            ViewBag.CategoryID = new SelectList(categories, "CategoryId", "CategoryName", selectedCategory);
        }

        private void PopulateSupplierDropDownList(object selectedSupplier = null)
        {
            var suppliers = _productService.GetSuppliers();
            ViewBag.SupplierID = new SelectList(suppliers, "SupplierId", "CompanyName", selectedSupplier);
        }

    }
}