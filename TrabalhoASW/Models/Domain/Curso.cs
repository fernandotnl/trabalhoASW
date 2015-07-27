using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TrabalhoASW.Models
{
    public class Curso
    {
        /* Propriedades */
        [Key, Required]
        public int id { get; set; }
        [Required, MaxLength(100), MinLength(5)]
        public string nome { get; set; }
        [Required]
        public Coordenador coordenador { get; set; }
        public ICollection<Aluno> alunos { get; set; }
        public ICollection<Professor> professores { get; set; }
    }
}
