using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.Models;

namespace WebShop1.ViewModels
{
    /// <summary>
    /// Модель представлення Кошика
    /// </summary>
    public class CartsIndexViewModel
    {
        /// <summary>
        /// Кошик
        /// </summary>
        public Cart Cart { get; set; }
    }
}
