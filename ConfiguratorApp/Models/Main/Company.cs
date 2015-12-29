using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ConfiguratorApp
{
    public class Company
    {

        #region Fields

        /// <summary>
        /// Поле. Идентификатор
        /// </summary>
        private int _companyId;

        /// <summary>
        /// Поле. Название компании
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле. Логин
        /// </summary>
        private string _accountName;

        /// <summary>
        /// Поле. Логотип
        /// </summary>
        private Picture _logo;

        /// <summary>
        /// Поле. Дата регистрации
        /// </summary>
        private DateTime _dateOfRegistration;

        /// <summary>
        /// Поле. Баланс
        /// </summary>
        private double _balance;

        /// <summary>
        /// Поле. Адрес компании
        /// </summary>
        private string _address;

        /// <summary>
        /// Поле. Имя директора
        /// </summary>
        private string _nameOfBoss;

        /// <summary>
        /// Поле. Номер телефона
        /// </summary>
        private string _phone;

        #endregion

        #region Properties

        /// <summary>
        /// Свойство. Идентификатор
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        public int CompanyId
        {
            get; set;
        }

        /// <summary>
        /// Свойство. Название компании
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Свойство. Баланс
        /// </summary>
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        /// <summary>
        /// Свойство. Логин
        /// </summary>
        public string AccountName
        {
            get
            {
                return _accountName;
            }
            set
            {
                _accountName = value;
            }
        }

        [ForeignKey("Logo")]
        public int PictureId { get; set; }

        /// <summary>
        /// Свойство. Логотип компании
        /// </summary>
        
        [JsonIgnore]
        public Picture Logo
        {
            get
            {
                return _logo;
            }
            set
            {
                _logo = value;
            }
        }

        /// <summary>
        /// Свойство. Дата регистрации
        /// </summary>
        public DateTime DateOfRegistration
        {
            get
            {
                return _dateOfRegistration;
            }
            set
            {
                _dateOfRegistration = value;
            }
        }
        
        /// <summary>
        /// Свойство. Адрес компании
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        
        /// <summary>
        /// Свойство. Имя директора
        /// </summary>
        public string NameOfBoss
        {
            get
            {
                return _nameOfBoss;
            }
            set
            {
                _nameOfBoss = value;
            }
        }

        /// <summary>
        /// Свойство. Моб телефон контактного лица
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }

        /// <summary>
        /// Свойство. Список емайлов компании
        /// </summary>
        public List<Email> Emails { get; set; }

        /// <summary>
        /// Свойство. Список опций
        /// </summary>
        public List<Option> Options { get; set; }

        #endregion

    }
}
