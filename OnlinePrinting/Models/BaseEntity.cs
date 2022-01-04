using MongoDB.Bson.Serialization.Attributes;
using System;

namespace OnlinePrinting.Models {
    /// <summary>
    /// Базовый класс сущности
    /// </summary>
    public abstract class BaseEntity {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [BsonId]
        [BsonElement("_id")]
        public Guid? Id { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime? CreatedOn { get; set; } = DateTime.Now;
    }

}
