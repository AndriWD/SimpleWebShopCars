using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebShop1.Data.Interfaces;
using WebShop1.Data.Models;
using WebShop1.Data.Repository;
using WebShop1.ViewModels;

namespace WebShop1.Controllers
{
    /// <summary>
    /// Головна сторінка
    /// </summary>
    public class HomeController : Controller
    {
        private readonly IAllCars carRepository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="carRep"></param>
        public HomeController(IAllCars carRep)
        {
            carRepository = carRep;
            
        }
        /// <summary>
        /// Всі автомобілі
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            var FavouriteItems = carRepository.GetFavouriteCars;
            HomeIndexViewModel viewHome = new HomeIndexViewModel() { FavouriteCars= FavouriteItems };
            return View(viewHome);
        }
    }
}
