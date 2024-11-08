using KitapDuragi.entity;

namespace KitapDuragi.business.Abstract
{
    public interface ICartService
    {
          void InitializeCart(string userId);
        Cart GetCartByUserId(string userId);
        void AddToCart(string userId,int productId,int quantity);
        void DeleteFromCart(string userId, int productId);
        void ClearCart(int cartId);
    }
}