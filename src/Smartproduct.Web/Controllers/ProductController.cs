using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smartproduct.Interface.Category;
using Smartproduct.Interface.File;
using Smartproduct.Interface.Product;
using Smartproduct.Model.Product;
using Smartproduct.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartproduct.Web.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        Product product = new Product();
        private readonly IProduct _productRouter;
        private readonly ICategory _categoryRouter;
        private readonly IFile _fileRouter;
        public ProductController(IProduct productRouter, ICategory categoryRouter, IFile fileRouter)
        {
            _productRouter = productRouter;
            _categoryRouter = categoryRouter;
            _fileRouter = fileRouter;
        }

        [HttpGet]
        public async Task<IActionResult> Currentproducts()
        {
            var products = await _productRouter.GetAllProducts();
            products = products.Where(x => x.CreatedBy == User.Identity.Name).ToList();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Newproduct()
        {
            var product = new Product();
            product.CategoryList = await _categoryRouter.GetAllCategories();
            product.CategoryList = product.CategoryList.Where(x => x.IsActive == true).ToList();
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Newproduct(Product product, IFormFile file)
        {
            product.CategoryList = await _categoryRouter.GetAllCategories();
            var check = await _productRouter.DuplicateProduct(product.Name);
            if(check)
            {
                product.Errormessage = $"Product already exists";
                return View(product);
            }

            var prod = await _productRouter.GetAllProducts();
            var maxProduct = prod.Count();

            product.ProductCode = $"{DateTime.Now.ToString("yyyyMM") + "-0" + (maxProduct + 1)}";

            if (file != null) {
                product.Image = "Yes";
                product.CreatedBy = User.Identity.Name;
                var p = await _productRouter.Post(product);
                await _fileRouter.Insert(FileHelper.AssignFile(file, User.Identity.Name,p.ProductId));
            }
            else
            {
                product.Image = "No";
                product.CreatedBy = User.Identity.Name;
                await _productRouter.Post(product);
            }
            return RedirectToAction("Currentproducts");
        }


        [HttpGet]
        public async Task<IActionResult> Editproduct(int ProductId)
        {
            product = await _productRouter.GetProductById(ProductId);
            product.CategoryList = await _categoryRouter.GetAllCategories();
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Editproduct(Product product, IFormFile file)
        {
            if (file != null)
            {
                product.Image = "Yes";
                product.CreatedBy = User.Identity.Name;
                var p = await _productRouter.Put(product);
                await _fileRouter.Insert(FileHelper.AssignFile(file, User.Identity.Name, product.ProductId));
            }
            else
            {
                product.Image = "No";
                product.CreatedBy = User.Identity.Name;
                await _productRouter.Put(product);
            }
            return RedirectToAction("Currentproducts");
        }

        [HttpGet]
        public async Task<IActionResult> Deleteproduct(int ProductId)
        {
            await _productRouter.Delete(ProductId);

            return RedirectToAction("Currentproducts");
        }

        [HttpGet]
        public async Task<IActionResult> Viewproduct(int ProductId)
        {
            var vm = new ProductFileViewModel();
            vm.Product = await _productRouter.GetProductById(ProductId);
            var files = await _fileRouter.GetAllFiles();
            vm.File = files.Where(x => x.ProductId == ProductId).OrderByDescending(x => x.FileId).Take(1).FirstOrDefault();
            if (vm.File != null)
            {
                vm.File.FileDataStr = Encoding.ASCII.GetString(vm.File.FileData, 0, vm.File.FileData.Length);
            }
            return View(vm);
        }

    }
}
