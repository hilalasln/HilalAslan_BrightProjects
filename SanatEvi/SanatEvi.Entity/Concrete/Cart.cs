﻿using SanatEvi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Entity.Concrete
{
    public class Cart:BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
