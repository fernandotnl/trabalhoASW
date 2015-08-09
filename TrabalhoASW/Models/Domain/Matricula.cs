using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TrabalhoASW.Models
{
    public class Matricula
    {
        /* Propriedades */
        [Key, Required]
        public int matriculaId { get; set; }
        [Required]
        // [Required, MaxLength(15), MinLength(3)]
        public string codigo { get; set; }
        [Required]
        public TipoMatricula tipoMatricula { get; set; }
        public int pessoaId { get; set; }
        [Required]
        public Pessoa pessoa { get; set; }
    }
}
