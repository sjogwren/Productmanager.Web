using Smartproduct.Interface.Category;
using Smartproduct.Model.Category;
using Smartproduct.Web.Apirouter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Smartproduct.Apirouter
{
    public class CategoryService : ICategory
    {
        /// <summary>
        /// Checks for duplicate categories
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>Returns a Boolean</returns>
        public async Task<bool> DuplicateCategory(string Name)
        {
            return await Connection.GetAsync<bool>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Category}CheckIfCategoryExist/Name?Name={Name}"));
        }

        /// <summary>
        /// Checks for duplicate categorie codes
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>Returns a Boolean</returns>
        public async Task<bool> CheckIfCategoryCodeExist(string Name)
        {
            return await Connection.GetAsync<bool>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Category}CheckIfCategoryCodeExist/{Name}"));
        }

        /// <summary>
        /// Gets the category by their Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Returns a single category</returns>
        public async Task<Category> GetCategoryById(int Id)
        {
            return await Connection.GetAsync<Category>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Category}GetById/{Id}"));
        }

        /// <summary>
        /// Gets all categories
        /// </summary>
        /// <returns>Returns all category</returns>
        public async Task<List<Category>> GetAllCategories()
        {
            return await Connection.GetAsync<List<Category>>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Category}GetAll"));
        }

        /// <summary>
        /// Creates a new category
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Returns a boolean</returns>
        public async Task<bool> Post(Category category)
        {
            return await Connection.InsertAsync(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Category}Post/Insert"), category);
        }

        /// <summary>
        /// Updates an existing category
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Returns a boolean</returns>
        public async Task<bool> Put(Category category)
        {
            return await Connection.PutAsync(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Category}Update/Update"), category);
        }

        /// <summary>
        /// Deletes a category
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Returns a Boolean</returns>
        public async Task<bool> Delete(Category category)
        {
            return await Connection.PutAsync(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Category}Delete/Delete"), category);
        }
    }
}
