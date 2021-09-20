using Microsoft.EntityFrameworkCore;
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
    /// Репозиторій Автомобілів
    /// </summary>
    public class CarRepository : IAllCars
    {
        private readonly AppDbContext db;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="appDbContext"></param>
        public CarRepository(AppDbContext appDbContext)
        {
            db = appDbContext;
        }
        /// <summary>
        /// Всі автомобілі
        /// </summary>
        public IEnumerable<Car> Cars => db.Cars.Include(c => c.Category);
        /// <summary>
        /// Отримати автомобілі з позначкою "Улюблені"
        /// </summary>
        public IEnumerable<Car> GetFavouriteCars => db.Cars.Where(c => c.IsFavourite == true).Include(c => c.Category);
        /// <summary>
        /// Отримати автомобіль по ідентифікатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Car GetCar(int id)
        {
            return db.Cars.Find(id);
        }
    }
}
