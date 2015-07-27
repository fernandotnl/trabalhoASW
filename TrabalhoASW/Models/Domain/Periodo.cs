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
        int id { get; set; }
        [Required, MaxLength(25), MinLength(3)]
        string nome { get; set; }
        [Required]
        DateTime dataInicio { get; set; }
        [Required]
        DateTime dataFim { get; set; }
    }
}
