using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_Test_Project.Data;

namespace Technical_Test_Project.Repository
{
    public class CartRepository : ICartRepository
    {

        private readonly TestDbContext _context;

        public CartRepository(TestDbContext context)
        {
            _context = context;
        }

        public async Task<Cart> AddCart(int userId)
        {
            await _context.AddAsync(new Cart() { UserId = userId });
            await _context.SaveChangesAsync();
            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.UserId == userId);

            return cart;
        }

        public async Task<Cart> AddUpdateCartItems(int cartId, CartItem cartItem)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.Id == cartId);
            if (cart != null)
            {
                if (CheckIfCartItemExist(cart, cartItem.ProductId).Result)
                {

                    var newItem = cart.CartItems.FirstOrDefault(x => x.ProductId == cartItem.ProductId);
                    newItem.Quantity = cartItem.Quantity;
                    newItem.TotalPrice = cartItem.TotalPrice;
                }
            }

            else
            {
                cart.CartItems.Add(cartItem);
            }
            return cart;

        }



        public async Task<Cart> GetCartByUserId(int userId)
        {
            var cart = await _context.Carts.Include(x => x.CartItems).FirstOrDefaultAsync(x => x.UserId == userId);
            if (cart == null)
            {
                cart = await AddCart(userId);
            }
            return cart;
        }

        public Task<List<Cart>> GetCartItemsByCartId(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cart>> RemoveCartItem(int cartId, int cartItemId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckIfCartItemExist(Cart cart, int productId)
        {
            return Task.FromResult(cart.CartItems.Any(x => x.ProductId == productId));
        }


    }

}
