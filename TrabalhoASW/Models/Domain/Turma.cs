using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models
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
        public Turno turno { get; set; }
        [Required]
        public int periodoId { get; set; }
        public virtual Periodo periodo { get; set; }
        [Required]
        public int professorId { get; set; }
        public virtual Professor professor { get; set; }
        [Required]
        public int disciplinaId { get; set; }
        public virtual Disciplina disciplina { get; set; }
        public virtual ICollection<Aluno> alunos { get; set; }
        public virtual ICollection<Avaliacao> avaliacoes { get; set; }
    }
}