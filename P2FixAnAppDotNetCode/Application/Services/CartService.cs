using System.Collections.Generic;
using System.Linq;
using P2FixAnAppDotNetCode.Models;

namespace P2FixAnAppDotNetCode.Application.Services
{
    /// <summary>
    /// The CartService class
    /// </summary>
    public class CartService : ICartService
    {
        /// <summary>
        ///  _cartLines for stocking list off Product 
        /// </summary>
        private List<CartLine> _cartLines = new List<CartLine>();
        /// <summary>
        /// Read-only property for display only
        /// </summary>
        public IEnumerable<CartLine> Lines => 
            GetCartLineList();

        /// <summary>
        /// Return the actual cartline list
        /// </summary>
        /// <returns></returns>
        private List<CartLine> GetCartLineList() => 
            _cartLines;

        /// <summary>
        /// Adds a product in the cart or increment its quantity in the cart if already added
        /// </summary>//
        public void AddItem(Product product, int quantity)
        {
            List<CartLine> cartLines = GetCartLineList();
            CartLine line = cartLines
                .Where(p => p.Product.Id == product.Id)
                .FirstOrDefault();

            if (line == null)
            {
                cartLines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        /// <summary>
        /// Removes a product form the cart
        /// </summary>
        public void RemoveLine(Product product) =>
            GetCartLineList().RemoveAll(l => l.Product.Id == product.Id);

        /// <summary>
        /// Get total value of a cart
        /// </summary>
        public double GetTotalValue() =>  GetCartLineList()
                    .Sum(l => l.Product.Price * l.Quantity);

        /// <summary>
        /// Get average value of a cart
        /// </summary>
        public double GetAverageValue()
        {
            List<CartLine> cartLines = GetCartLineList();
            if (cartLines.Count == 0) return 0.0;

            double totalValue = GetTotalValue();
            int totalQuantity = cartLines.Sum(l => l.Quantity);

            return totalValue / totalQuantity;
        }

        /// <summary>
        /// Looks after a given product in the cart and returns if it finds it
        /// </summary>
        public Product FindProductInCartLines(int productId) =>
            GetCartLineList()
                    .FirstOrDefault(l => l.Product.Id == productId)?.Product;

        /// <summary>
        /// Get a specific cartline by its index
        /// </summary>
        public CartLine GetCartLineByIndex(int index) =>
            Lines.ToArray()[index];

        /// <summary>
        /// Clears a the cart of all added products
        /// </summary>
        public void Clear() => GetCartLineList().Clear();
    }


}
