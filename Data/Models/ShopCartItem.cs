using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.Models;

namespace WebShop1.Data.Mocks
{
    /// <summary>
    /// Елемент корзини
    /// </summary>
    public class ShopCartItem
    {
        /// <summary>
        /// Ідентифікатор
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Ідентифікатор Автомобіля
        /// </summary>
        public int CarId { get; set; }
        /// <summary>
        /// Автомобіль
        /// </summary>
        public Car Car { get; set; }
        /// <summary>
        /// Ціна
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// Ідентифікатор Корзини
        /// </summary>
        public string ShopCartId { get; set; }

    }
}
