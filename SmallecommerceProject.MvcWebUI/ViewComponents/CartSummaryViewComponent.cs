using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using SmallecommerceProject.MvcWebUI.Models;
using SmallecommerceProject.MvcWebUI.Services;

namespace SmallecommerceProject.MvcWebUI.ViewComponents
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private ICartSessionService _cartSessionService;

        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {

                Cart = _cartSessionService.GetCart()

            };
            return View(model);
        }

    }
}
