using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop1.Data.Models
{
    /// <summary>
    /// Замовлення
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Ідентифікатор
        /// </summary>
        [BindNever]
        public int Id { get; set; }
        /// <summary>
        /// Ім'я
        /// </summary>
        [Display(Name="Введіть Ім'я")]
        [MaxLength(15)]
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Прізвище
        /// </summary>
        [Display(Name = "Введіть Фаміоію")]
        [Required]
        [MaxLength(15)]
        public string Surname { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        [Display(Name = "Введіть Адрес")]
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        /// <summary>
        /// Номер мобільного телефону
        /// </summary>
        [Display(Name = "Введіть номер телефону")]
        [MinLength(10)]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(15)]
        [Required(ErrorMessage ="Довжина номера телефону менше 10 символів")]
        public string Phone { get; set; }
        /// <summary>
        /// Емайл
        /// </summary>    
        [Display(Name = "Введіть емайл")]
        [DataType(DataType.EmailAddress)]
        [Required]
        [MaxLength(20)]
        public string Email { get; set; }
        /// <summary>
        /// Час оформлення замовлення
        /// </summary>
        public DateTime orderTime { get; set; }
        /// <summary>
        /// Деталі замовлення
        /// </summary>
        public List<OrderDetail> orderDetails { get; set; }
    } 
}
