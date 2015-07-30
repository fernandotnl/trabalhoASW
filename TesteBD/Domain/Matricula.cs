﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TesteBD
{
    public class Matricula
    {
        /* Propriedades */
        [Key, Required]
        public int matriculaId { get; set; }
        [Required, MaxLength(15), MinLength(3)]
        public string codigo { get; set; }
        [Required]
        public TipoMatricula tipoMatricula { get; set; }
    }
}
