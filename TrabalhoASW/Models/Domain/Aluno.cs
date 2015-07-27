using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoASW.Models
{
    public class Aluno : Perfil
    {
        /* Propriedades */
        [Key, Required]
        int id { get; set; }
        [Required]
        Pessoa pessoa { get; set; }
        [Required]
        Curso curso { get; set; }
        ICollection<Turma> turmas { get; set; }
        [InverseProperty("aluno")]
        ICollection<Nota> notas { get; set; }

        /* Métodos */
        public ICollection<Nota> consultarNotasAluno(Aluno aluno)
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
