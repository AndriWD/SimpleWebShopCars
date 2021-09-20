using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.DAL;
using WebShop1.Data.Models;

namespace WebShop1.Data
{
    /// <summary>
    /// Клас Ініціалізації БД
    /// </summary>
    public class DbObjects
    {
        /// <summary>
        /// Ініціалізація БД
        /// </summary>
        /// <param name="db"></param>
        public static void Initial(AppDbContext db)
        {           

            if (db.Categories == null)
            {
                db.Categories.AddRange(Categories.Select(c => c.Value));
            }
            if (db.Cars == null)
            {
                db.Cars.AddRange();
            }
            db.SaveChanges();
        }
        private static Dictionary<string, Category> categories;
        /// <summary>
        /// Доступ до існуючих категорій / Створення існуючих категорій
        /// </summary>
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var newCategories = new Category[] {
                    new Category() { CategoryName = "Електромобілі", DescriptionCategory = "Сучасний вид транспорту" },
                    new Category() { CategoryName = "Автомобілі", DescriptionCategory = "Такий собі вид транспорту" }
                    };
                    categories = new Dictionary<string, Category>();
                    foreach (var item in newCategories)
                    {
                        categories.Add(item.CategoryName, item);
                    }

                };
                return categories;
            }
            
        }
    }
}
