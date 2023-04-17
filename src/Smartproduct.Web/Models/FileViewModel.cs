using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartproduct.Web.Models
{
    public class FileViewModel
    {
        public List<Model.File.File> Files { get; set; }
        public Model.File.File File { get; set; }
        public int CountFiles { get; set; }
    }
}
