using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteBD
{
    public class Turma
    {
        public Turma()
        {
            this.alunos = new HashSet<Aluno>();
            this.avaliacoes = new List<Avaliacao>(); 
        }

        /* Propriedades */
        [Key, Required]
        public int turmaId { get; set; }
        [Required]
        public string codigo { get; set; }
        [Required]
        public Periodo periodo { get; set; }
        [Required]
        public Turno turno { get; set; }

        public int professorId { get; set; }
        [Required]
        public Professor professor { get; set; }
        public virtual ICollection<Aluno> alunos { get; set; }
        public Disciplina disciplina { get; set; }
        public ICollection<Avaliacao> avaliacoes { get; set; }
    }
}