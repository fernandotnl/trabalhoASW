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
        public int Id { get; set; }
        [Required]
        public Aluno aluno { get; set; }
        [Required]
        public Avaliacao avaliacao { get; set; }
        [Required]
        public double valor { get; set; }
    }
}
