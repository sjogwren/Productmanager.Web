using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartproduct.Interface.Product
{
    public interface IProduct
    {
        Task<bool> Bulkinsert(List<Model.Product.Product> product);
        Task<Model.Product.Product> Post(Smartproduct.Model.Product.Product product);
        Task<bool> Put(Smartproduct.Model.Product.Product product);
        Task<Smartproduct.Model.Product.Product> GetProductById(int Id);
        Task<List<Smartproduct.Model.Product.Product>> GetAllProducts();
        Task<bool> Delete(int ProductId);
        Task<bool> DuplicateProduct(string Name);
    }
}
