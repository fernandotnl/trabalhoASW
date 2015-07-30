using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TesteBD
{
    public class Nota
    {
        /* Propriedades */
        [Key, Required]
        public int notaId { get; set; }

        public int alunoId { get; set; }
        [Required]
        public Aluno aluno { get; set; }

        public int avaliacaoId { get; set; }
        [Required]
        public Avaliacao avaliacao { get; set; }
        [Required]
        public double valor { get; set; }
    }
}
