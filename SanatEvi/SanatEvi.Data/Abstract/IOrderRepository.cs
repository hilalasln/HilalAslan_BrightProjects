﻿using SanatEvi.Entity.Concrete;
using SanatEvi.Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Data.Abstract
{
    public interface IOrderRepository: IGenericRepository<Order>
    {
        Task<List<Order>> GetAllOrdersAsync(string userId = null, bool dateSort = false, OrderStatus? orderStatus = null);
        Task<string> GetTotalAsync(int action);
    }
}
