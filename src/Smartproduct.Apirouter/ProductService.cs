using Smartproduct.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smartproduct.Model;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using Smartproduct.Interface.Product;
using Smartproduct.Apirouter;
using Smartproduct.Web.Apirouter;
using Smartproduct.Model.Product;
using System.Data;

namespace Smartproduct.Service
{
    public class ProductService : IProduct
    {
        /// <summary>
        /// Uses a TVP to bulk insert via SQL
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Returns a Boolean</returns>
        public async Task<bool> Bulkinsert(List<Model.Product.Product> product)
        {
            return await Connection.PostAsyncBool(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Product}Bulkinsert/Insert"), product);
        }
        /// <summary>
        /// Checks for duplicate categories
        /// </summary>
        /// <param name="Name"></param>
        /// <returns>Returns a Boolean</returns>
        public async Task<bool> DuplicateProduct(string Name)
        {
            return await Connection.GetAsync<bool>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Product}CheckIfProductExist/{Name}"));
        }

        /// <summary>
        /// Gets the product by their Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Returns a single product</returns>
        public async Task<Product> GetProductById(int Id)
        {
            return await Connection.GetAsync<Product>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Product}GetById/{Id}"));
        }


        public async Task<List<Product>> GetAllProducts()
        {
            return await Connection.GetAsync<List<Product>>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Product}GetAll"));
        }

        /// <summary>
        /// Creates a new product
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Returns a boolean</returns>
        public async Task<Model.Product.Product> Post(Product product)
        {
            return await Connection.PostAsync(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Product}Post/Insert"), product);
        }

        /// <summary>
        /// Updates an existing product
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Returns a boolean</returns>
        public async Task<bool> Put(Product product)
        {
            return await Connection.PutAsync(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Product}Put/Update"), product);
        }

        /// <summary>
        /// Deletes an existing product
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Returns a boolean</returns>
        public async Task<bool> Delete(int ProductId)
        {
            return await Connection.GetAsync<bool>(new Uri(UriHelper.Api.FruitSaApi, $"{UriHelper.Controller.Product}Delete/{ProductId}"));
        }
    }
}
