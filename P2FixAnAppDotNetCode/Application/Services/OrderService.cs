using System;
using P2FixAnAppDotNetCode.Infrastructure.Repositories;
using P2FixAnAppDotNetCode.Models;

namespace P2FixAnAppDotNetCode.Application.Services
{
    /// <summary>
    /// Provides services to manage an order
    /// </summary>
    public class OrderService : IOrderService
    {
        private readonly ICartService _cart;
        private readonly IOrderRepository _repository;
        private readonly IProductService _productService;

        public OrderService(ICartService cart, IOrderRepository orderRepo, IProductService productService)
        {
            _repository = orderRepo;
            _cart = cart;
            _productService = productService;
        }

        /// <summary>
        /// Saves an order
        /// </summary>
        public void SaveOrder(Order order)
        {
            order.Date = DateTime.Now;
            _repository.Save(order);
            UpdateInventory();
        }

        /// <summary>
        /// Update the product quantities inventory and clears the cart
        /// </summary>
        private void UpdateInventory()
        {
            _productService.UpdateProductQuantities(_cart as CartService);
            _cart.Clear();
        }
    }
}
