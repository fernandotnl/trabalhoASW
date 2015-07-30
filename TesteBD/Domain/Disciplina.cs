using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TesteBD
{
    public class Disciplina
    {
        /* Propriedades */
        [Key, Required]
        public int disciplinaId { get; set; }
        [Required, MaxLength(15), MinLength(3)]
        public string codigo { get; set; }
        [Required, MaxLength(60), MinLength(5)]
        public string nome { get; set; }
    }
}
