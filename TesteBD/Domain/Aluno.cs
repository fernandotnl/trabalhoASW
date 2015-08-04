using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBD
{
    public class Aluno 
    {

        public Aluno()
        {
            this.turmas = new List<Turma>();
            this.notas = new List<Nota>();
        }
        /* Propriedades */
        [Key, Required]
        public int alunoId { get; set; }
        [Required]
        public Pessoa pessoa { get; set; }

        public int cursoId { get; set; }
        [Required]
        public Curso curso { get; set; }
       
        public virtual ICollection<Turma> turmas { get; set; }
        public virtual ICollection<Nota> notas { get; set; }

        /* Métodos */
        /*public ICollection<Nota> consultarNotasAluno(Aluno aluno)
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
        }*/
    }
}
