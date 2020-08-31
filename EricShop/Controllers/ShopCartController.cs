using EricShop.Models;
using EricShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricShop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAesopRepository _aesopRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAesopRepository aesopRepository, ShopCart shopCart)
        {
            _aesopRepository = aesopRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            _shopCart.ShopCartItems = _shopCart.GetShopCartItems();

            var shopCartViewModel = new ShopCartViewModel
            {
                ShopCart = _shopCart,
                ShopCartTotal = _shopCart.GetShopCartTotal()
            };

            return View(shopCartViewModel);
        }

        public RedirectToActionResult AddToShopCart(int aesopId)
        {
            var selectedAesop = _aesopRepository.GetAllAesop.FirstOrDefault(c => c.AesopId == aesopId);

            if (selectedAesop != null)
            {
                _shopCart.AddToCart(selectedAesop, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShopCart(int aesopId)
        {
            var selectedAesop = _aesopRepository.GetAllAesop.FirstOrDefault(c => c.AesopId == aesopId);

            if (selectedAesop != null)
            {
                _shopCart.RemoveFromCart(selectedAesop);
            }

            return RedirectToAction("Index");
        }
        public RedirectToActionResult ClearCart()
        {
            _shopCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
