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
        int id { get; set; }
        [Required]
        string codigo { get; set; }
        [Required]
        Periodo periodo { get; set; }
        [Required]
        Turno turno { get; set; }
        [Required]
        Professor professor { get; set; }
        ICollection<Aluno> alunos { get; set; }
        Disciplina disciplina { get; set; }
        ICollection<Avaliacao> avaliacoes { get; set; }
    }
}