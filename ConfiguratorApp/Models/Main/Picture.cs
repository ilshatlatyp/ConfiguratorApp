using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;


namespace ConfiguratorApp
{
    public class Picture
    {
        /// <summary>
        /// Свойство. Идентификатор
        /// </summary>
        public int Picture_Id { get; set; }

        /// <summary>
        /// Свойство. Картинка
        /// </summary>
        public Image Image { get; set; }
    }
}
