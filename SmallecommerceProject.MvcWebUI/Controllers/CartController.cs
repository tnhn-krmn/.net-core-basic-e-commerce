using Microsoft.AspNetCore.Mvc;
using SmallecommerceProject.Business.Abstract;
using SmallecommerceProject.Entities.Concrete;
using SmallecommerceProject.MvcWebUI.Models;
using SmallecommerceProject.MvcWebUI.Services;
using System;

namespace SmallecommerceProject.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _sessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService sessionService, ICartService cartService, IProductService productService)
        {
            _sessionService = sessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _sessionService.GetCart();
            _cartService.AddToCart(cart,productToBeAdded);
            _sessionService.SetCart(cart);
            TempData.Add("message", String.Format("Ürün, {0}, başarılı bir şekilde eklendi",productToBeAdded.ProductName));
            return RedirectToAction("Index", "Product");
        }

        public ActionResult List()
        {
            var cart = _sessionService.GetCart();

            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };

            return View(cartListViewModel);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _sessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _sessionService.SetCart(cart);
            TempData.Add("message", String.Format("Ürün, başarılı bir şekilde silinid"));
            return RedirectToAction("List");
        }
    }
}
