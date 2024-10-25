using Microsoft.AspNetCore.Mvc;
using P2FixAnAppDotNetCode.Models.Services;

namespace P2FixAnAppDotNetCode.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private readonly CartService _cart;

        public CartSummaryViewComponent(ICartService cart)
        {
            _cart = cart as CartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
