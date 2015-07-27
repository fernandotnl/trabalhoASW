using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TrabalhoASW.Models
{
    public class Disciplina
    {
        /* Propriedades */
        [Key, Required]
        int id { get; set; }
        [Required, MaxLength(15), MinLength(3)]
        string codigo { get; set; }
        [Required, MaxLength(60), MinLength(5)]
        string nome { get; set; }
    }
}
