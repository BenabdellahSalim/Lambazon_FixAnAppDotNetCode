using P2FixAnAppDotNetCode.Infrastructure.Repositories;
using P2FixAnAppDotNetCode.Models;
using System.Collections.Generic;
using System.Linq;

namespace P2FixAnAppDotNetCode.Application.Services
{
    /// <summary>
    /// This class provides services to manages the products
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;

        public ProductService(IProductRepository productRepository, IOrderRepository orderRepository)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
        }

        /// <summary>
        /// Get all product from the inventory
        /// </summary>
        public List<Product> GetAllProducts() =>
           _productRepository.GetAllProducts().ToList();

        /// <summary>
        /// Get a product form the inventory by its id
        /// </summary>
        public Product GetProductById(int id) => _productRepository.GetAllProducts().FirstOrDefault(p => p.Id == id);

        /// <summary>
        /// Update the quantities left for each product in the inventory depending of ordered the quantities
        /// </summary>
        public void UpdateProductQuantities(CartService cart)
        {
            foreach (var line in cart.Lines)
            {
                var product = GetProductById(line.Product.Id);

                if (product != null)
                {
                    _productRepository.UpdateProductStocks(line.Product.Id, line.Quantity);
                }
            }
        }
    }
}
