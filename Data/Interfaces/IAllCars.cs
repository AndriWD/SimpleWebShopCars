using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.Models;

namespace WebShop1.Data.Interfaces
{
    /// <summary>
    /// Контракт для репозиторія Автомобілів
    /// </summary>
    public interface IAllCars
    {
        /// <summary>
        /// Отримати всі автомобілі
        /// </summary>
        IEnumerable<Car> Cars { get; }
        /// <summary>
        /// Отримати автомобілі з позначкою "Улюблені"
        /// </summary>
        
        IEnumerable<Car> GetFavouriteCars { get;}
        /// <summary>
        /// Отримати автомобіль по ідентифікатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Car GetCar(int id);
        

    }
}
