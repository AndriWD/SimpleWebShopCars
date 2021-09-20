namespace WebShop1.Data.Models
{
    /// <summary>
    /// Деталі замовлення
    /// </summary>
    public class OrderDetail
    {
        /// <summary>
        /// Ідентифікатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Ідентифікатор замовлення
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// Замовлення
        /// </summary>
        public Order Order { get; set; }
        /// <summary>
        /// Ідентифікатор Автомобіля
        /// </summary>
        public int CarId { get; set; }
        /// <summary>
        /// Автомобіль
        /// </summary>
        public Car Car { get; set; }
        /// <summary>
        /// Ціна
        /// </summary>
        public uint Price { get; set; }

    }
}