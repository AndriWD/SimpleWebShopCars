using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop1.Data.Models
{
    /// <summary>
    /// Категорії
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Ідентифікатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Назва Категорії
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// Опис Категорії
        /// </summary>
        public string DescriptionCategory { get; set; }
        /// <summary>
        /// Автомобілі даної категорії
        /// </summary>
        public List<Car> Cars { get; set; }
    }
}
