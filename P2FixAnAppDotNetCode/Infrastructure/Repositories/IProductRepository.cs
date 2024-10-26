using System.Collections.Generic;
using P2FixAnAppDotNetCode.Models;

namespace P2FixAnAppDotNetCode.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();

        void UpdateProductStocks(int productId, int quantityToRemove);
    }
}
