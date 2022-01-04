using System.ComponentModel;

namespace OnlinePrinting.Models.Enums {
    /// <summary>
    /// Тип кадрирования изображения
    /// </summary>
    public enum FramingType {
        /// <summary>
        /// Кадр целиком
        /// </summary>
        [Description("Кадр целиком")]
        Entirely,
        /// <summary>
        /// Обрезать
        /// </summary>
        [Description("Обрезать")]
        Trim
    }
}