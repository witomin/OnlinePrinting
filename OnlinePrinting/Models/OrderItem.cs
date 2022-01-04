using OnlinePrinting.Models.Services;

namespace OnlinePrinting.Models {
    /// <summary>
    /// Элемент заказа
    /// </summary>
    public class OrderItem {
        /// <summary>
        /// Услуга
        /// </summary>
        public BaseService Service { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price {
            get {
                return Service.Price;
            }
        }
        /// <summary>
        /// Цена со скидкой
        /// </summary>
        public decimal DiscountedPrice {
            get {
                return Service.DiscountedPrice;
            }
                }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Cost {
            get {
                return Price * Count;
            }
        }
        /// <summary>
        /// Стоимость со скидкой
        /// </summary>
        public decimal DiscountedCost {
            get {
                return DiscountedPrice * Count;
            }
        }
    }
}