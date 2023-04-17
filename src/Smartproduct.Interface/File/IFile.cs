using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartproduct.Interface.File
{
    public interface IFile
    {
        Task<bool> Insert(Smartproduct.Model.File.File File);
        Task<bool> Post(IFormFile File);
        Task<Smartproduct.Model.File.File> GetFileById(int Id);
        Task<bool> Put(Smartproduct.Model.File.File file);
        Task<List<Smartproduct.Model.File.File>> GetAllFiles();
    }
}
