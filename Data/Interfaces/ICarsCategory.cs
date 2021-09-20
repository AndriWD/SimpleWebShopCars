using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.Models;

namespace WebShop1.Data.Interfaces
{
    /// <summary>
    /// Контракт для репозиторію Категорій
    /// </summary>
    public interface ICarsCategory
    {
        /// <summary>
        /// Отримати всі Категорії
        /// </summary>
        IEnumerable<Category> GetAllCategories { get; }
    }
}
