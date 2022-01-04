using System;

namespace OnlinePrinting.Models {
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order: BaseEntity {
        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        public Guid ClientId { get; set; }
        /// <summary>
        /// Адрес доставки заказа
        /// </summary>
        public Address DeliveryAddress { get; set; }
        /// <summary>
        /// Плановая дата доставки
        /// </summary>
        public DateTime PlannedDeliveryDate { get; set; }
        /// <summary>
        /// Статус заказа
        /// </summary>
        public OrderStatus Status { get; set; }

        public Order() {
            Id = Guid.NewGuid();
            Status = OrderStatus.New;
        }
    }
}
