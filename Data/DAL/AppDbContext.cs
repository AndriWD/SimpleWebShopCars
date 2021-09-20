using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.Mocks;
using WebShop1.Data.Models;

namespace WebShop1.Data.DAL
{
    /// <summary>
    /// Доступ до даних
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        /// <summary>
        /// Автомобілі
        /// </summary>
        public DbSet<Car> Cars { get; set; }
        /// <summary>
        /// Категорії
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        /// <summary>
        /// Елементи кошика
        /// </summary>
        public DbSet<ShopCartItem> ShopCarItems { get; set; }
        /// <summary>
        /// Замовлення
        /// </summary>
        public DbSet<Order> Orders { get; set; }
        /// <summary>
        /// Деталі замовлення
        /// </summary>
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
