using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TrabalhoASW.Models
{
    public class Matricula
    {
        /* Propriedades */
        [Key, Required]
        int id { get; set; }
        [Required, MaxLength(15), MinLength(3)]
        string codigo { get; set; }
        [Required]
        TipoMatricula tipoMatricula { get; set; }
    }
}
