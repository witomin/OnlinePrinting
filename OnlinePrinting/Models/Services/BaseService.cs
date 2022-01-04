using MongoDB.Bson.Serialization.Attributes;
using System;

namespace OnlinePrinting.Models.Services {
    /// <summary>
    /// Базовый класс услуги
    /// </summary>
    public abstract class BaseService {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [BsonId]
        [BsonElement("_id")]
        public Guid? Id { get; set; }
        /// <summary>
        /// Отображаемое имя услуги
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; protected set; }
        /// <summary>
        /// Цена со скидкой
        /// </summary>
        public decimal DiscountedPrice { get; protected set; }
        /// <summary>
        /// Время выполнения
        /// </summary>
        public int ExecutionTime { get; set; }
        /// <summary>
        /// Рассчитать цену услуги
        /// </summary>
        abstract public void Calculate();
    }
}