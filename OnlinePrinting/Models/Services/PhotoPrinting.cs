using OnlinePrinting.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePrinting.Models.Services {
    /// <summary>
    /// Услуга печать фоторгафии
    /// </summary>
    public class PhotoPrinting: BaseService {
        /// <summary>
        /// Уникальный идентификатор формата печати
        /// </summary>
        public Guid FormatId { get; set; }
        /// <summary>
        /// Уникальный идентификатор типа бумаги
        /// </summary>
        public Guid PaperType { get; set; }
        /// <summary>
        /// Тип кадрирования
        /// </summary>
        public FramingType FramingType { get; set; }
        /// <summary>
        /// Уникальный идентификатор типа упаковки
        /// </summary>
        public Guid PackagingType { get; set; }

        public override void Calculate() {
            throw new NotImplementedException();
        }
    }
}
