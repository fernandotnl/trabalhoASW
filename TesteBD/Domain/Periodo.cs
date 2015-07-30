using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TesteBD
{
    public class Periodo
    {
        /* Propriedades */
        [Key, Required]
        public int priodoId { get; set; }
        [Required, MaxLength(25), MinLength(3)]
        public string nome { get; set; }
        [Required]
        public DateTime dataInicio { get; set; }
        [Required]
        public DateTime dataFim { get; set; }
    }
}
