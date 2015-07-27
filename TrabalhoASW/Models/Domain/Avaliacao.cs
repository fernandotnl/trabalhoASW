using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TrabalhoASW.Models
{
    public class Avaliacao
    {
        /* Propriedades */
        [Key, Required]
        int id { get; set; }
        [Required, MaxLength(50), MinLength(5)]
        string nome { get; set; }
        [InverseProperty("avaliacao")]
        ICollection<Nota> notas { get; set; }
    }
}
