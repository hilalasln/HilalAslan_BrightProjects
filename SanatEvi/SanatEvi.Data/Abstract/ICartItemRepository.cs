﻿using SanatEvi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Data.Abstract
{
    public interface ICartItemRepository : IGenericRepository<CartItem>
    {
        Task ChangeQuantityAsync(CartItem item, int quantity);
        void ClearCart(int cartId);
    }
}
