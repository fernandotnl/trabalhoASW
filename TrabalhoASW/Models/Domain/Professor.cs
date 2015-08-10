using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoASW.Models
{
    public class Professor 
    {

        public Professor()
        {
            this.turmas = new List<Turma>();
        }

        /* Propriedades */
        [Key, Required]
        public int professorId { get; set; }
        public virtual Pessoa pessoa { get; set; }
        [Required]
        public int cursoId { get; set; }
        [ForeignKey("cursoId")]
        public Curso curso { get; set; }
        public virtual ICollection<Turma> turmas { get; set; }
       
    }
}
