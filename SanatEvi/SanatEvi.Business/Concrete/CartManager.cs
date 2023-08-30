using SanatEvi.Business.Abstract;
using SanatEvi.Data.Abstract;
using SanatEvi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartRepository _cartRepository;

        public CartManager(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task AddToCart(string userId, int courseId, int quantity)
        {
            await _cartRepository.AddToCartAsync(userId, courseId, quantity);
        }

        public async Task DeleteAsync(string userId)
        {
            var cart = await GetCartByUserId(userId);
            _cartRepository.Delete(cart);
        }

        public Task<Cart> GetByIdAsync(int id)
        {
            return _cartRepository.GetByIdAsync(id);
        }

        public async Task<Cart> GetCartByUserId(string id)
        {
            return await _cartRepository.GetCartByUserId(id);
        }

        public async Task InitializeCart(string userId)
        {
            await _cartRepository.CreateAsync(new Cart { UserId = userId });
        }
    }
}
