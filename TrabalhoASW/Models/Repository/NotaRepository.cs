using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class NotaRepository : BaseRepository<Nota>
    {
        ContextoBD contexto;

        public List<Nota> buscarTodos()
        {
            return new List<Nota>();
        }
        public ICollection<Nota> consultarNotasAluno(Aluno aluno)
        {
            Nota nota = new Nota();
            /*DbSet<Nota> notas = contexto.notas;
            DbSet<Aluno> alunos = contexto.alunos;
            var consulta = from nota in notas 
                           join aluno2 in alunos on nota.GetAluno().GetId() equals aluno2.GetId()
                           select nota;*/
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