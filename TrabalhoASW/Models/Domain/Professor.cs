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
       
        /* Métodos */
        public ICollection<Nota> consultarNotasAluno(Aluno aluno)
        {
            return new List<Nota>();
        }
        public ICollection<Nota> consultarNotasAlunos(List<Aluno> alunos)
        {
            return new List<Nota>();
        }
        public ICollection<Nota> consultarNotasTurma(Turma turma)
        {
            return new List<Nota>();
        }
        public ICollection<Nota> consultarNotasDisciplina(Disciplina disciplina)
        {
            return new List<Nota>();
        }
        public ICollection<Nota> consultarNotasPeriodo(Periodo periodo)
        {
            return new List<Nota>();
        }
    }
}
