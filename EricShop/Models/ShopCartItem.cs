﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricShop.Models
{
    public class ShopCartItem
    {
        public int ShopCartItemId { get; set; }
        public string ShopCartId { get; set; }
        public Aesop Aesop { get; set; }
        public int Amount { get; set; }
    }
}
