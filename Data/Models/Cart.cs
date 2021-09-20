using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.DAL;
using WebShop1.Data.Mocks;

namespace WebShop1.Data.Models
{
    /// <summary>
    /// Кошик
    /// </summary>
    public class Cart
    {   
        private readonly AppDbContext db;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="appDbContext"></param>
        public Cart(AppDbContext appDbContext)
        {
            db = appDbContext;
        }
        /// <summary>
        /// Ідентифікатор
        /// </summary>
        public string CartId { get; set; }
        /// <summary>
        /// Список елементів в корзині
        /// </summary>
        public List<ShopCartItem> ListShopItems { get; set; }
        /// <summary>
        /// Отримати корзину для поточної сесії
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>

        public static Cart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDbContext>();
            string CartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", CartId);

            return new Cart(context) { CartId = CartId };
        }
        /// <summary>
        /// Добавити до корзини
        /// </summary>
        /// <param name="car"></param>
        /// <param name="amount"></param>
        public void AddToCart(Car car, int amount = 1)
        {
            db.ShopCarItems.Add(new ShopCartItem()
            {
                ShopCartId = CartId,
                Car = car,
                Price = car.Price
            });
            db.SaveChanges();
        }
        /// <summary>
        /// Отримати елементи корзини
        /// </summary>
        /// <returns></returns>
        public List<ShopCartItem> GetShopCartItems()
        {
            return db.ShopCarItems.Where(c => c.ShopCartId == CartId).Include(s => s.Car).ToList();
        }
    }
}
