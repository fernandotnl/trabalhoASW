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
        int id { get; set; }
        [Required, MaxLength(100), MinLength(5)]
        string nome { get; set; }
        [Required]
        Coordenador coordenador { get; set; }
        [InverseProperty("curso")]
        ICollection<Aluno> alunos { get; set; }
        [InverseProperty("curso")]
        ICollection<Professor> professores { get; set; }
    }
}
