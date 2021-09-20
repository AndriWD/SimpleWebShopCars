using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.Models;

namespace WebShop1.Data.Interfaces
{/// <summary>
/// Контракт для репозиторію Замовлень
/// </summary>
    public interface IAllOrders
    {
        /// <summary>
        /// Створити замовлення
        /// </summary>
        /// <param name="order"></param>
        void createOrder(Order order);
        
    }
}
