using ConsoleToWebAPI.Models;
using System.Collections.Generic;

namespace ConsoleToWebAPI.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();

        string GetName();
    }
}