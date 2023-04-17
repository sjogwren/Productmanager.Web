using Smartproduct.Model.File;
using Smartproduct.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartproduct.Web.Models
{
    public class ProductFileViewModel
    {
        public Product Product { get; set; }
        public File File { get; set; }
    }
}
