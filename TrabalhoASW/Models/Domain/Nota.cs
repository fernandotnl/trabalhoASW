using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TrabalhoASW.Models
{
    public class Nota
    {
        /* Propriedades */
        [Key, Required]
        int id { get; set; }
        [Required]
        Aluno aluno { get; set; }
        [Required]
        Avaliacao avaliacao { get; set; }
        [Required]
        double valor { get; set; }
    }
}
