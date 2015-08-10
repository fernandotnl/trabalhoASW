using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoASW.Models
{
    public class Coordenador 
    {
        /* Propriedades */
        [Key, Required]
        public int coordenadorId { get; set; }
        public virtual Pessoa pessoa { get; set; }
        [Required]
        public int cursoId { get; set; }
        [ForeignKey("cursoId")]
        public virtual Curso curso { get; set; }
        
    }
}
