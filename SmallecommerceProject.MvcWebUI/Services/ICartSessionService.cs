using SmallecommerceProject.Entities.Concrete;

namespace SmallecommerceProject.MvcWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
