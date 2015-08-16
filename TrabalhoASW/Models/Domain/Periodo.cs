using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TrabalhoASW.Models
{
    public class Periodo
    {
        /* Propriedades */
        [Key, Required]
        public int periodoId { get; set; }
        [Required]
        //[Required, MaxLength(25), MinLength(3)]
        public string nome { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "99/99/9999")]
        public DateTime dataInicio { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "99/99/9999")]
        public DateTime dataFim { get; set; }
    }
}
