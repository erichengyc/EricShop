using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricShop.Models
{
    public class ShopCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ShopCartItems { get; set; }

        public ShopCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShopCart(context) { ShopCartId = cartId };
        }

        public void AddToCart(Aesop aesop, int amount)
        {
            var shopCartItem = _appDbContext.ShopCartItems.SingleOrDefault(
                s => s.Aesop.AesopId == aesop.AesopId && s.ShopCartId == ShopCartId);

            if (shopCartItem == null)
            {
                shopCartItem = new ShopCartItem
                {
                    ShopCartId = ShopCartId,
                    Aesop = aesop,
                    Amount = amount
                };

                _appDbContext.ShopCartItems.Add(shopCartItem);
            }
            else
            {
                shopCartItem.Amount++;
            }

            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Aesop aesop)
        {
            var shopCartItem = _appDbContext.ShopCartItems.SingleOrDefault(
                s => s.Aesop.AesopId == aesop.AesopId && s.ShopCartId == ShopCartId);

            var localAmount = 0;

            if (shopCartItem != null)
            {
                if (shopCartItem.Amount > 1)
                {
                    shopCartItem.Amount--;
                    localAmount = shopCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShopCartItems.Remove(shopCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShopCartItem> GetShopCartItems()
        {
            return ShopCartItems ?? (ShopCartItems = _appDbContext.ShopCartItems.Where(c => c.ShopCartId == ShopCartId)
                .Include(s => s.Aesop)
                .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext.ShopCartItems.Where(c => c.ShopCartId == ShopCartId);

            _appDbContext.ShopCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

        public decimal GetShopCartTotal()
        {
            var total = _appDbContext.ShopCartItems.Where(c => c.ShopCartId == ShopCartId)
                .Select(c => c.Aesop.Price * c.Amount).Sum();

            return total;
        }

    }
}
