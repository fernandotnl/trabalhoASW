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
        public Avaliacao()
        {
            this.notas = new List<Nota>();
        }
        /* Propriedades */
        [Key, Required]
        public int avaliacaoId { get; set; }
        [Required]
        //[Required, MaxLength(50), MinLength(5)]
        public string nome { get; set; }
        [Required]
        public int turmaId { get; set; }
        [ForeignKey("turmaId")]
        public virtual Turma turma { get; set; }
        public virtual ICollection<Nota> notas { get; set; }
    }
}
