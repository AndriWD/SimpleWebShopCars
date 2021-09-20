using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop1.Data.Models
{
    /// <summary>
    /// Автомобіль
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Ідентифікатор
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Назва Автомобіля
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Короткий опис
        /// </summary>
        public string ShortDescroption { get; set; }
        /// <summary>
        /// Довгий опис
        /// </summary>
        public string LingDescription { get; set; }
        /// <summary>
        /// Картинка
        /// </summary>
        public string Image { get; set; } //класно ми просто будемо тут зберігати адрес картинки (URL) по-суті як я робив
        /// <summary>
        /// Ціна
        /// </summary>
        public ushort Price { get; set; } //цікаво тип використовується, тобто він по замовчуванню зразу не може бути менше нуля
        /// <summary>
        /// Позначка "Улюблений"
        /// </summary>
        public bool IsFavourite { get; set; }
        /// <summary>
        /// Позначка "Є в продажі"
        /// </summary>
        public bool available { get; set; }
        /// <summary>
        /// Ідентифікатор Категорії
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Категорія
        /// </summary>
        public virtual Category Category { get; set; }
    }
}
