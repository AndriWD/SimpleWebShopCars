using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.Interfaces;
using WebShop1.Data.Models;

namespace WebShop1.Controllers
{
    /// <summary>
    /// Контроллер Замовлень
    /// </summary>
    public class OrdersController : Controller
    {
        private IAllOrders db;
        private readonly Cart cart;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="allOrders"></param>
        /// <param name="cart"></param>
        public OrdersController(IAllOrders allOrders, Cart cart)
        {
            db = allOrders;
            this.cart = cart;
        }
        /// <summary>
        /// Заповнити форму замовлення
        /// </summary>
        /// <returns></returns>
        public IActionResult Checkout()
        {
            return View();
        }
        /// <summary>
        /// Замовити автомобіль
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            cart.ListShopItems = cart.GetShopCartItems();

            if (cart.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас немає товарів!");
            }

            if(ModelState.IsValid)
            {
                db.createOrder(order);
                return RedirectToAction("Complete");
            }
            //отут класно, навіть якщо валідація не пройдена, коректно заповнені дані не пропадуть
            return View(order);
        }
        /// <summary>
        /// Сповіщає про успішно здійснене замовлення
        /// </summary>
        /// <returns></returns>
        public IActionResult Complete()
        {
            ViewBag.Message = "Покупка успішно здійснена";
            return View();
        }
    }
}
