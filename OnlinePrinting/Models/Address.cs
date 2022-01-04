namespace OnlinePrinting.Models {
    /// <summary>
    /// Почтовый адрес
    /// </summary>
    public class Address {
        /// <summary>
        /// Почтовый индекс
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// Область
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// Населенный пункт
        /// </summary>
        public string Locality { get; set; }
        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Дом
        /// </summary>
        public string House { get; set; }
        /// <summary>
        /// Корпус
        /// </summary>
        public string Building { get; set; }
        /// <summary>
        /// Квартира
        /// </summary>
        public string Flat { get; set; }
    }
}