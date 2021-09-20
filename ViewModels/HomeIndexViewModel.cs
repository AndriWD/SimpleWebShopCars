using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.Models;

namespace WebShop1.ViewModels
{
    /// <summary>
    /// Модель представлення головної сторінки з автомобілями
    /// </summary>
    public class HomeIndexViewModel
    {
        /// <summary>
        /// Автомобілі з позначкою "Улюблені"
        /// </summary>
        public IEnumerable<Car> FavouriteCars { get; set; }
    }
}
