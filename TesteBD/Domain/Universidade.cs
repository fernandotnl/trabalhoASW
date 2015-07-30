﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteBD
{

    public class Universidade
    {
        /* Propriedades */
        [Key, Required]
        public int universidadeId { get; set; }
        [Required, MaxLength(100), MinLength(5)]
        public string nome { get; set; }
        public virtual  ICollection<Curso> cursos { get; set; }
    }
}