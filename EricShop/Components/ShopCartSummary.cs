using EricShop.Models;
using EricShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricShop.Components
{
    public class ShopCartSummary : ViewComponent
    {
        private readonly ShopCart _shopCart;

        public ShopCartSummary(ShopCart shopCart)
        {
            _shopCart = shopCart;
        }

        public IViewComponentResult Invoke()
        {
            _shopCart.ShopCartItems = _shopCart.GetShopCartItems();

            var shopCartViewModel = new ShopCartViewModel
            {
                ShopCart = _shopCart,
                ShopCartTotal = _shopCart.GetShopCartTotal()
            };

            return View(shopCartViewModel);
        }
    }
}
