using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_Test_Project.Data;

namespace Technical_Test_Project.Repository
{
    public interface ICartRepository
    {
        Task<Cart> GetCartByUserId(int userId);
        Task<Cart> AddCart(int userId);

        Task<List<Cart>> GetCartItemsByCartId(int cartId);
        Task<Cart> AddUpdateCartItems(int cartId, CartItem cartItems);
        Task<List<Cart>> RemoveCartItem(int cartId, int cartItemId);
    }
}
