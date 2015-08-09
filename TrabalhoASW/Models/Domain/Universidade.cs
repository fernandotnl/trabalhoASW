using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models
{

    public class Universidade
    {
        public Universidade()
        {
            this.cursos = new List<Curso>();
        }
        /* Propriedades */
        [Key]
        public int universidadeId { get; set; }
        [Required]
        //[Required, MaxLength(100), MinLength(5)]
        public string nome { get; set; }
        public virtual  ICollection<Curso> cursos { get; set; }
    }
}