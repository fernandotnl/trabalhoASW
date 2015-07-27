using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models
{
    public class Turma
    {
        /* Propriedades */
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string codigo { get; set; }
        [Required]
        public Periodo periodo { get; set; }
        [Required]
        public Turno turno { get; set; }
        [Required]
        public Professor professor { get; set; }
        public ICollection<Aluno> alunos { get; set; }
        public Disciplina disciplina { get; set; }
        public ICollection<Avaliacao> avaliacoes { get; set; }
    }
}