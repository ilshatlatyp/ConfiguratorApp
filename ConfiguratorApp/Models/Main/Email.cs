using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfiguratorApp
{
    public class Email
    {
        /// <summary>
        /// Свойство. Идентификатор
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        public int EmailId { get; set; }

        /// <summary>
        /// Свойство. Емайл компании
        /// </summary>
        public string CompanyEmail { get; set; }
    }
}
