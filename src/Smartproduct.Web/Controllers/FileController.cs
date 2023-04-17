using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Smartproduct.Interface.File;
using Smartproduct.Interface.Product;
using Smartproduct.Web.Models;
using Smartproduct.Web.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Smartproduct.Web.Controllers
{
    [Authorize]
    public class FileController : Controller
    {
        FileViewModel fvm = new FileViewModel();
        private readonly IFile _fileRouter;
        private readonly IProduct _productRouter;
        public FileController(IFile fileRouter, IProduct productRouter)
        {
            _fileRouter = fileRouter;
            _productRouter = productRouter;
        }

        [HttpGet]
        public async Task<IActionResult> Files()
        {
            fvm.Files = await _fileRouter.GetAllFiles();
            fvm.Files = fvm.Files.Where(x => x.CreatedBy == User.Identity.Name).ToList();
            if (fvm.Files != null)
                fvm.CountFiles = fvm.Files.Count();
            else
                fvm.CountFiles = 0;

            return View(fvm);
        }

        [HttpPost]
        public async Task<IActionResult> Files(IFormFile File)
        {
            var products = await _productRouter.GetAllProducts();
            await _fileRouter.Insert(FileHelper.AssignFile(File, User.Identity.Name, null));
            await _productRouter.Bulkinsert(FileHelper.GetDataFromExcel(File,products,User.Identity.Name));
            return RedirectToAction("Currentproducts", "Product");
        }

        [HttpGet]
        public async Task<IActionResult> Download(int FileId)
        {
            var documents = await _fileRouter.GetFileById(FileId);
            return File(documents.FileData, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", documents.FileContentType);
        }

    }
}
