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
        [System.ComponentModel.DataAnnotations.Key]
        public int PictureId { get; set; }

        /// <summary>
        /// Свойство. Картинка
        /// </summary>
        public byte[] Image { get; set; }
    }
}
