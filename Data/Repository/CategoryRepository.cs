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
    /// Репозиторій Категорій
    /// </summary>
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDbContext db;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="appDbContext"></param>
        public CategoryRepository(AppDbContext appDbContext)
        {
            db = appDbContext;
        }
        /// <summary>
        /// Отримати всі Категорії
        /// </summary>
        public IEnumerable<Category> GetAllCategories => db.Categories.Include(c => c.Cars);
    }
}
