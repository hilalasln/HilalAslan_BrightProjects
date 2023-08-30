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
    public class EfCoreCartItemRepository : EfCoreGenericRepository<CartItem>, ICartItemRepository
    {
        public EfCoreCartItemRepository(SanatEviContext _appContext) : base(_appContext)
        {

        }
        SanatEviContext AppContext
        {
            get { return _dbContext as SanatEviContext; }
        }
        public async Task ChangeQuantityAsync(CartItem item, int quantity)
        {
            item.Quantity = quantity;
            AppContext.CartItems.Update(item);
            await AppContext.SaveChangesAsync();
        }

        public void ClearCart(int cartId)
        {
            AppContext
                .CartItems
                .Where(ci => ci.CartId == cartId)
                .ExecuteDelete();
        }
    }
}
