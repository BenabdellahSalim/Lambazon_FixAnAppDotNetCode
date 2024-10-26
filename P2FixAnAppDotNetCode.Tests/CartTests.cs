using System.Collections.Generic;
using System.Linq;
using P2FixAnAppDotNetCode.Models;
using P2FixAnAppDotNetCode.Repositories;
using P2FixAnAppDotNetCode.Services;
using Xunit;
using P2FixAnAppDotNetCode.Application.Services;
using P2FixAnAppDotNetCode.Infrastructure.Repositories;

namespace P2FixAnAppDotNetCode.Tests
{
    /// <summary>
    /// The CartService test class
    /// </summary>
    public class CartTests
    {
        [Fact]
        public void AddItemInCart()
        {
            CartService cart = new CartService();
            Product product1 = new Product(1, 0, 20, "name", "description");
            Product product2 = new Product(1, 0, 20, "name", "description");

            cart.AddItem(product1, 1);
            cart.AddItem(product2, 1);

            Assert.NotEmpty(cart.Lines);
            Assert.Single(cart.Lines);
            Assert.Equal(2, cart.Lines.First().Quantity);
        }

        [Fact]
        public void GetAverageValue()
        {
            ICartService cart = new CartService();
            IProductRepository productRepository = new ProductRepository();
            IOrderRepository orderRepository = new OrderRepository();
            IProductService productService = new ProductService(productRepository, orderRepository);

            IEnumerable<Product> products = productService.GetAllProducts();
            cart.AddItem(products.First(p => p.Id == 2), 2);
            cart.AddItem(products.First(p => p.Id == 5), 1);
            double averageValue = cart.GetAverageValue();
            double expectedValue = (9.99 * 2 + 895.00) / 3;

            Assert.Equal(expectedValue, averageValue);
        }

        [Fact]
        public void GetTotalValue()
        {
            ICartService cart = new CartService();
            IProductRepository productRepository = new ProductRepository();
            IOrderRepository orderRepository = new OrderRepository();
            IProductService productService = new ProductService(productRepository, orderRepository);

            IEnumerable<Product> products = productService.GetAllProducts();
            cart.AddItem(products.First(p => p.Id == 1), 1);
            cart.AddItem(products.First(p => p.Id == 4), 3);
            cart.AddItem(products.First(p => p.Id == 5), 1);
            double totalValue = cart.GetTotalValue();
            double expectedValue = 92.50 + 32.50 * 3 + 895.00;

            Assert.Equal(expectedValue, totalValue);
        }

        [Fact]
        public void FindProductInCartLines()
        {
            CartService cart = new CartService();
            Product product = new Product(999, 0, 20, "name", "description");

            cart.AddItem(product, 1);
            Product result = cart.FindProductInCartLines(999);

            Assert.NotNull(result);
        }
    }
}
