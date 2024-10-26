using System.Collections.Generic;
using P2FixAnAppDotNetCode.Models;

namespace P2FixAnAppDotNetCode.Infrastructure.Repositories
{
    /// <summary>
    /// The class that manages order data
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders;

        public OrderRepository()
        {
            _orders = new List<Order>();
        }

        /// <summary>
        /// Saves an order
        /// </summary>
        public void Save(Order order)
        {
            _orders.Add(order);
        }
    }
}