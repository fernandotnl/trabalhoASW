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
        public List<Nota> buscarTodos()
        {
            return new List<Nota>();
        }
        public ICollection<Nota> consultarNotasAluno(Aluno alunoParam)
        {
            ICollection<Nota> notasAluno = new List<Nota>();
            using (var contexto = new ContextoBD())
            {
                DbSet<Nota> notas = contexto.notas;
                DbSet<Aluno> alunos = contexto.alunos;
                var consulta = from nota in notas
                               join aluno in alunos on nota.alunoId equals aluno.alunoId
                               where aluno.alunoId == alunoParam.alunoId
                               select nota;
                notasAluno = consulta.ToList<Nota>();
            }
            return notasAluno;
        }
        public ICollection<Nota> consultarNotasTurma(Turma turmaParam)
        {
            ICollection<Nota> notasAluno = new List<Nota>();
            using (var contexto = new ContextoBD())
            {
                DbSet<Nota> notas = contexto.notas;
                DbSet<Aluno> alunos = contexto.alunos;
                DbSet<Turma> turmas = contexto.turmas;
                DbSet<Avaliacao> avaliacoes = contexto.avaliacoes;
                var consulta = from nota in notas
                               join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                               join turma in turmas on avaliacao.turmaId equals turma.turmaId
                               where turma.turmaId == turmaParam.turmaId
                               select nota;
                notasAluno = consulta.ToList<Nota>();
            }
            return new List<Nota>();
        }

        public ICollection<Nota> consultarNotasTurma(Turma turmaParam, Aluno alunoParam)
        {
            ICollection<Nota> notasAluno = new List<Nota>();
            using (var contexto = new ContextoBD())
            {
                DbSet<Nota> notas = contexto.notas;
                DbSet<Aluno> alunos = contexto.alunos;
                DbSet<Turma> turmas = contexto.turmas;
                DbSet<Avaliacao> avaliacoes = contexto.avaliacoes;
                var consulta = from nota in notas
                               join aluno in alunos on nota.alunoId equals aluno.alunoId
                               join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                               join turma in turmas on avaliacao.turmaId equals turma.turmaId
                               where turma.turmaId == turmaParam.turmaId && aluno.alunoId == alunoParam.alunoId
                               select nota;
                notasAluno = consulta.ToList<Nota>();
            }
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