using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EricShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShopCart _shopCart;

        public OrderRepository(AppDbContext appDbContext, ShopCart shopCart)
        {
            _appDbContext = appDbContext;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shopCart.GetShopCartTotal();
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shopCartItems = _shopCart.GetShopCartItems();

            foreach (var shopCartItem in shopCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shopCartItem.Amount,
                    Price = shopCartItem.Aesop.Price,
                    AesopId = shopCartItem.Aesop.AesopId,
                    OrderId = order.OrderId
                };

                _appDbContext.OrderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}
