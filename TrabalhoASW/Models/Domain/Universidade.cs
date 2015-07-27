using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models
{
    public class Universidade
    {
        /* Propriedades */
        [Key, Required]
        int id { get; set; }
        [Required, MaxLength(100), MinLength(5)]
        string nome { get; set; }
        ICollection<Curso> cursos { get; set; }
    }
}