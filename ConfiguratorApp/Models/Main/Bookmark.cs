using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfiguratorApp
{
    public class Bookmark
    {
        /// <summary>
        /// Свойство. Идентификатор
        /// </summary>
        public int Bookmark_Id { get; set; }

        /// <summary>
        /// Свойство. Название закладки
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Свойство. Список опций в закладке
        /// </summary>
        public List<Option> Options { get; set; }

        /// <summary>
        /// Свойство. Список пакетов
        /// </summary>
        public List<Package> Packages { get; set; }
    }
}
