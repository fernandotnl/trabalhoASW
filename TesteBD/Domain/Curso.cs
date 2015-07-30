using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TesteBD
{
    public class Curso
    {
        /* Propriedades */
        [Key, Required]
        public int cursoId { get; set; }
        [Required, MaxLength(100), MinLength(5)]
        public string nome { get; set; }
        [InverseProperty("curso")]
        public Coordenador coordenador { get; set; }
        public int universidadeId { get; set; }
        public Universidade universidade { get; set; }
        public virtual ICollection<Aluno> alunos { get; set; }
        public virtual ICollection<Professor> professores { get; set; }
    }
}
