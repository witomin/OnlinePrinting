using System;
using System.Collections.Generic;

namespace OnlinePrinting.Models {
    /// <summary>
    /// Клиент
    /// </summary>
    public class Client : BaseEntity {
        /// <summary>
        /// Логин
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string SecondName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string ThirdName { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Почтовый адрес
        /// </summary>
        public Address Address { get; set; }
        /// <summary>
        /// Адреса доставки
        /// </summary>
        public List<Address> DeliveryAddresses { get; set; }
        /// <summary>
        /// Статус активности
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// Аватар
        /// </summary>
        public string AvatarUrl { get; set; }

        public Client() {
            Id = Guid.NewGuid();
        }
    }
}
