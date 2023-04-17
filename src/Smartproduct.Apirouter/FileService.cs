using Microsoft.AspNetCore.Http;
using Smartproduct.Interface.File;
using Smartproduct.Model.File;
using Smartproduct.Web.Apirouter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Smartproduct.Apirouter
{
    public class FileService : IFile
    {
        /// <summary>
        /// Gets all files
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Returns all file object</returns>
        public async Task<List<File>> GetAllFiles()
        {
            return await Connection.GetAsync<List<File>>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.File}GetAll"));
        }

        /// <summary>
        /// Gets a file by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Returns a file object</returns>
        public async Task<File> GetFileById(int Id)
        {
            return await Connection.GetAsync<File>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.File}GetById/{Id}"));
        }

        /// <summary>
        /// Creates a new file
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Returns a Boolean</returns>
        public async Task<bool> Post(IFormFile file)
        {
            return await Connection.PostAsyncBool(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.File}Post/Insert"), file);
        }

        /// <summary>
        /// Creates a new file
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Returns a Boolean</returns>
        public async Task<bool> Insert(File file)
        {
            return await Connection.InsertAsync(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.File}Insert/Insert"), file);
        }

        /// <summary>
        /// Updates an existing file
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Returns a boolean</returns>
        public async Task<bool> Put(File file)
        {
            return await Connection.PutAsync(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Category}Put/Update"), file);
        }
    }
}
