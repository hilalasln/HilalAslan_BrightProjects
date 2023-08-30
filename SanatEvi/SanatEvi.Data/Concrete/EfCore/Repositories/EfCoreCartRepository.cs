using Microsoft.EntityFrameworkCore;
using SanatEvi.Data.Abstract;
using SanatEvi.Data.Concrete.EfCore.Contexts;
using SanatEvi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart>, ICartRepository
    {

        public EfCoreCartRepository(SanatEviContext _appContext) : base(_appContext)
        {

        }
        SanatEviContext AppContext
        {
            get { return _dbContext as SanatEviContext; }
        }
        public async Task AddToCartAsync(string userId, int courseId, int quantity)
        {
            var cart = await GetCartByUserId(userId);
            if (cart != null)
            {
                var index = cart.CartItems.FindIndex(ci => ci.CourseId == courseId);
                if (index < 0)
                {
                    cart.CartItems.Add(new CartItem
                    {
                        CourseId = courseId,
                        CartId = cart.Id,
                        Quantity = quantity
                    });
                }
                else 
                {
                    cart.CartItems[index].Quantity += quantity;
                }

                AppContext.Carts.Update(cart);
                await AppContext.SaveChangesAsync();
            }
        }

        public async Task<Cart> GetCartByUserId(string userId)
        {
            var result = await AppContext
                .Carts
                .Where(c => c.UserId == userId)
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Course)
                .FirstOrDefaultAsync();
            return result;
        }
    }
}
