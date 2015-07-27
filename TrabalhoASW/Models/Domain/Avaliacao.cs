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
        public int Id { get; set; }
        [Required, MaxLength(50), MinLength(5)]
        public string nome { get; set; }
        public ICollection<Nota> notas { get; set; }
    }
}
