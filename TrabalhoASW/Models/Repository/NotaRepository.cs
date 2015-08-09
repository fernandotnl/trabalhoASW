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
        public ICollection<Nota> buscarTodos()
        {
            ICollection<Nota> todasNotas = new List<Nota>();
            using (var contexto = new ContextoBD())
            {
                DbSet<Nota> notas = contexto.notas;
                var consulta = from nota in notas
                               select nota;
                todasNotas = consulta.ToList<Nota>();
            }
            return todasNotas;
        }

        public ICollection<Nota> consultarNotasAluno(Aluno alunoParam)
        {
            ICollection<Nota> notasAluno = new List<Nota>();
            using (var contexto = new ContextoBD())
            {
                DbSet<Nota> notas = contexto.notas;
                var consulta = from nota in notas
                               where nota.alunoId == alunoParam.alunoId
                               select nota;
                notasAluno = consulta.ToList<Nota>();
            }
            return notasAluno;
        }
        public ICollection<Nota> consultarNotasTurma(Turma turmaParam)
        {
            ICollection<Nota> notasTurma = new List<Nota>();
            using (var contexto = new ContextoBD())
            {
                DbSet<Nota> notas = contexto.notas;
                DbSet<Avaliacao> avaliacoes = contexto.avaliacoes;
                var consulta = from nota in notas
                               join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                               where avaliacao.turmaId == turmaParam.turmaId
                               select nota;
                notasTurma = consulta.ToList<Nota>();
            }
            return notasTurma;
        }

        public ICollection<Nota> consultarNotasAlunoTurma(Aluno alunoParam, Turma turmaParam)
        {
            ICollection<Nota> notasAlunoTurma = new List<Nota>();
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
                notasAlunoTurma = consulta.ToList<Nota>();
            }
            return notasAlunoTurma;
        }

        public ICollection<Nota> consultarNotasDisciplina(Disciplina disciplinaParam)
        {
            ICollection<Nota> notasDisciplina = new List<Nota>();
            using (var contexto = new ContextoBD())
            {
                DbSet<Nota> notas = contexto.notas;
                DbSet<Turma> turmas = contexto.turmas;
                DbSet<Avaliacao> avaliacoes = contexto.avaliacoes;
                var consulta = from nota in notas
                               join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                               join turma in turmas on avaliacao.turmaId equals turma.turmaId
                               where turma.disciplinaId == disciplinaParam.disciplinaId
                               select nota;
                notasDisciplina = consulta.ToList<Nota>();
            }
            return notasDisciplina;
        }

        public ICollection<Nota> consultarNotasAlunoDisciplina(Aluno alunoParam, Disciplina disciplinaParam)
        {
            ICollection<Nota> notasAlunoDisciplina = new List<Nota>();
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
                               where turma.disciplinaId == disciplinaParam.disciplinaId && aluno.alunoId == alunoParam.alunoId
                               select nota;
                notasAlunoDisciplina = consulta.ToList<Nota>();
            }
            return notasAlunoDisciplina;
        }
        public ICollection<Nota> consultarNotasPeriodo(Periodo periodoParam)
        {
            ICollection<Nota> notasPeriodo = new List<Nota>();
            using (var contexto = new ContextoBD())
            {
                DbSet<Nota> notas = contexto.notas;
                DbSet<Turma> turmas = contexto.turmas;
                DbSet<Avaliacao> avaliacoes = contexto.avaliacoes;
                var consulta = from nota in notas
                               join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                               join turma in turmas on avaliacao.turmaId equals turma.turmaId
                               where turma.periodoId == periodoParam.periodoId
                               select nota;
                notasPeriodo = consulta.ToList<Nota>();
            }
            return notasPeriodo;
        }

        public ICollection<Nota> consultarNotasAlunoPeriodo(Aluno alunoParam, Periodo periodoParam)
        {
            ICollection<Nota> notasAlunoPeriodo = new List<Nota>();
            using (var contexto = new ContextoBD())
            {
                DbSet<Nota> notas = contexto.notas;
                DbSet<Turma> turmas = contexto.turmas;
                DbSet<Aluno> alunos = contexto.alunos;
                DbSet<Avaliacao> avaliacoes = contexto.avaliacoes;
                var consulta = from nota in notas
                               join aluno in alunos on nota.alunoId equals aluno.alunoId
                               join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                               join turma in turmas on avaliacao.turmaId equals turma.turmaId
                               where turma.periodoId == periodoParam.periodoId && aluno.alunoId == alunoParam.alunoId
                               select nota;
                notasAlunoPeriodo = consulta.ToList<Nota>();
            }
            return notasAlunoPeriodo;
        }
    }
}