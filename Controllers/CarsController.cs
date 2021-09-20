using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.Interfaces;
using WebShop1.Data.Models;
using WebShop1.ViewModels;

namespace WebShop1.Controllers
{
    /// <summary>
    /// Контроллер Авто
    /// </summary>
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="allCars"></param>
        /// <param name="carsCategory"></param>
        public CarsController(IAllCars allCars, ICarsCategory carsCategory)
        {
            _allCars = allCars;
            _carsCategory = carsCategory;
        }
        /// <summary>
        /// Отримати автомобілі конкретної категорії,
        /// інакше всі
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        //представлення
        [Route("Cars/List")]
        [Route("Cars/List/category")]
        public ViewResult List(string  category)
        {
            string templeCategory = category;

            IEnumerable<Car> Cars = null ;

            string currentCategory = "";

            if (String.IsNullOrEmpty(category))
                Cars = _allCars.Cars;
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    Cars = _allCars.Cars.Where(c => c.Category.CategoryName.Equals("Електромобілі"));
                    currentCategory = "Електромобілі";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    Cars = _allCars.Cars.Where(c => c.Category.CategoryName.Equals("Автомобілі"));
                    currentCategory = "Автомобілі";
                }
            }
        CarsListViewModel viewModel = new CarsListViewModel() { CarCatagery = currentCategory, getAllCars = Cars };
            return View(viewModel);
        }
    }
}
