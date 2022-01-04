using System.ComponentModel;

namespace OnlinePrinting.Models {
    public enum OrderStatus {
        /// <summary>
        /// Новый
        /// </summary>
        [Description("Новый")]
        New,
        /// <summary>
        /// Обработка
        /// </summary>
        [Description("Обработка")]
        Processing,
        /// <summary>
        /// Выполнен
        /// </summary>
        [Description("Выполнен")]
        Complete,
        /// <summary>
        /// Отменен
        /// </summary>
        [Description("Отменен")]
        Cancelled,
        /// <summary>
        /// Ожидает доставки
        /// </summary>
        [Description("Ожидает доставки")]
        WaitingDelivery,
        /// <summary>
        /// Получен
        /// </summary>
        [Description("Получен")]
        Received,
        /// <summary>
        /// Ошибка оплаты
        /// </summary>
        [Description("Ошибка оплаты")]
        ErrorPayments,
        /// <summary>
        /// Оплачен
        /// </summary>
        [Description("Оплачен")]
        Payed
    }
}