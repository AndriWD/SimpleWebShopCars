using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.DAL;
using WebShop1.Data.Interfaces;
using WebShop1.Data.Models;

namespace WebShop1.Data.Repository
{
    /// <summary>
    /// Репозиторій Замовлень
    /// </summary>
    public class OrderRepository : IAllOrders
    {
        private readonly AppDbContext db;
        private readonly Cart cart;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="appDbContext"></param>
        /// <param name="cart"></param>
        public OrderRepository(AppDbContext appDbContext, Cart cart)
        {
            db = appDbContext;
            this.cart = cart;
        }
        /// <summary>
        /// Створити замовлення
        /// </summary>
        /// <param name="order"></param>
        public void createOrder(Order order) // цікаво реалізовано дуже навіть, створювати обєкт замовлення в спеціальному методі
        {
            order.orderTime = DateTime.Now;
            db.Orders.Add(order);

            var AllCarsInOrder = cart.ListShopItems;

            foreach (var item in AllCarsInOrder)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = item.Car.id,
                    OrderId = order.Id,
                    Price = item.Car.Price
                };
                db.OrderDetails.Add(orderDetail);                
            }
            db.SaveChanges();

        }
    }
}
