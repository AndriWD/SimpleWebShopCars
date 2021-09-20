using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.Models;

namespace WebShop1.ViewModels
{
    /// <summary>
    /// Модель представлення Автомобілів по категоріях
    /// </summary>
    public class CarsListViewModel
    {
        /// <summary>
        /// Всі Автомобілі
        /// </summary>
        public IEnumerable<Car> getAllCars { get; set; }
        /// <summary>
        /// Категорії
        /// </summary>
        public string CarCatagery { get; set; }
    }
}
