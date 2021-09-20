using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.Interfaces;
using WebShop1.Data.Models;
using WebShop1.Data.Repository;
using WebShop1.ViewModels;

namespace WebShop1.Controllers
{
    /// <summary>
    /// Контролер Кошика
    /// </summary>
    public class CartsController : Controller
    {
        private readonly IAllCars carRepository;
        private readonly Cart cart;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="carRep"></param>
        /// <param name="cart"></param>
        public CartsController(IAllCars carRep, Cart cart)
        {
            carRepository = carRep;
            this.cart = cart;
        }
        /// <summary>
        /// Представлення кошика
        /// </summary>
        /// <returns></returns>
        public ViewResult Index()
        {
            //вибачте, але якась уєбанська корзина получається
            var items = cart.GetShopCartItems();
            cart.ListShopItems = items;

            CartsIndexViewModel cartsView = new CartsIndexViewModel() { Cart = cart };
            return View();
        }

        /// <summary>
        /// Додати до корзини
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RedirectToActionResult AddToCart(int id)
        {
            var item = carRepository.Cars.FirstOrDefault(c => c.id == id);
            if (item != null)
            {
                cart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
