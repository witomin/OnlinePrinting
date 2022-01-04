using System.ComponentModel;

namespace OnlinePrinting.Models.Enums {
    /// <summary>
    /// Тип улучшения изображения
    /// </summary>
    public enum ImprovementType {
        /// <summary>
        /// Без автоулучшения
        /// </summary>
        [Description("Без автоулучшения")]
        Not,
        /// <summary>
        /// С автоулучшением
        /// </summary>
        [Description("С автоулучшением")]
        Improvement
    }
}
