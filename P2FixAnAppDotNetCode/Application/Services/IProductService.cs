using System.Collections.Generic;
using P2FixAnAppDotNetCode.Models;

namespace P2FixAnAppDotNetCode.Application.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void UpdateProductQuantities(CartService cart);
    }
}
