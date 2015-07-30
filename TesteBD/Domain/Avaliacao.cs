﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TesteBD
{
    public class Avaliacao
    {
        /* Propriedades */
        [Key, Required]
        public int avaliacaoId { get; set; }
        [Required, MaxLength(50), MinLength(5)]
        public string nome { get; set; }
        public ICollection<Nota> notas { get; set; }
    }
}