using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ConfiguratorApp
{
    public class Option
    {
        #region Fields

        /// <summary>
        /// Поле. Идентификатор
        /// </summary>
        private int _optionId;

        /// <summary>
        /// Поле. Название опции
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле. Количество
        /// </summary>
        private int _quantity;

        /// <summary>
        /// Поле. Цена
        /// </summary>
        private double _price;

        /// <summary>
        /// Поле. Описание
        /// </summary>
        private string _description;

        #endregion

        #region Properties

        /// <summary>
        /// Свойство. Идентификатор
        /// </summary>
        public int Option_Id
        {
            get
            {
                return _optionId;
            }
        }

        /// <summary>
        /// Свойство. Название опции
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
        /// Свойство. Количество
        /// </summary>
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

        /// <summary>
        /// Свойство. Стоимость опции
        /// </summary>
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        /// <summary>
        /// Свойство. Описание
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        /// <summary>
        /// Свойство. Картинка опции
        /// </summary>
        public List<Picture> Pictures
        {
            get; set;
        }

        /// <summary>
        /// Свойство. Список пакетов, в которых содержится опция
        /// </summary>
        public List<Package> Packages
        {
            get; set;
        }

        /// <summary>
        /// Свойство. Ссылка на компанию
        /// </summary>
        [ForeignKey("Company_Id")]
        [JsonIgnore]
        public Company Company
        {
            get; set;
        }

        /// <summary>
        /// Свойство. Ссылка на закладку
        /// </summary>
        [ForeignKey("Bookmark_Id")]
        [JsonIgnore]
        public Bookmark Bookmarks
        {
            get; set;
        }

        #endregion
    }
}
