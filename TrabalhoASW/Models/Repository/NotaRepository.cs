using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models.Repository
{
    public class NotaRepository : BaseRepository<Nota>
    {
        public ContextoBD context { get; set; }
        private bool disposed = false;
        
        public NotaRepository(ContextoBD context)
        {
            this.context = context;
        }

        public ICollection<Nota> buscarTodos()
        {
            ICollection<Nota> todasNotas = new List<Nota>();
            var notas = context.notas.Include(nota=>nota.avaliacao.turma.disciplina).Include(nota=>nota.aluno);
            var consulta = from nota in notas
                            select nota;
            todasNotas = consulta.ToList<Nota>();
            return todasNotas;
        }

        public ICollection<Nota> consultarNotasAluno(Aluno alunoParam)
        {
            ICollection<Nota> notasAluno = new List<Nota>();
            DbSet<Nota> notas = context.notas;
            var consulta = from nota in notas
                            where nota.alunoId == alunoParam.alunoId
                            select nota;
            notasAluno = consulta.ToList<Nota>();
            return notasAluno;
        }
        public ICollection<Nota> consultarNotasTurma(Turma turmaParam)
        {
            ICollection<Nota> notasTurma = new List<Nota>();
            DbSet<Nota> notas = context.notas;
            DbSet<Avaliacao> avaliacoes = context.avaliacoes;
            var consulta = from nota in notas
                            join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                            where avaliacao.turmaId == turmaParam.turmaId
                            select nota;
            notasTurma = consulta.ToList<Nota>();
            return notasTurma;
        }

        public ICollection<Nota> consultarNotasAlunoTurma(Aluno alunoParam, Turma turmaParam)
        {
            ICollection<Nota> notasAlunoTurma = new List<Nota>();
            DbSet<Nota> notas = context.notas;
            DbSet<Aluno> alunos = context.alunos;
            DbSet<Turma> turmas = context.turmas;
            DbSet<Avaliacao> avaliacoes = context.avaliacoes;
            var consulta = from nota in notas
                            join aluno in alunos on nota.alunoId equals aluno.alunoId
                            join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                            join turma in turmas on avaliacao.turmaId equals turma.turmaId
                            where turma.turmaId == turmaParam.turmaId && aluno.alunoId == alunoParam.alunoId
                            select nota;
            notasAlunoTurma = consulta.ToList<Nota>();
            return notasAlunoTurma;
        }

        public ICollection<Nota> consultarNotasDisciplina(Disciplina disciplinaParam)
        {
            ICollection<Nota> notasDisciplina = new List<Nota>();
            DbSet<Nota> notas = context.notas;
            DbSet<Turma> turmas = context.turmas;
            DbSet<Avaliacao> avaliacoes = context.avaliacoes;
            var consulta = from nota in notas
                            join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                            join turma in turmas on avaliacao.turmaId equals turma.turmaId
                            where turma.disciplinaId == disciplinaParam.disciplinaId
                            select nota;
            notasDisciplina = consulta.ToList<Nota>();
            return notasDisciplina;
        }

        public ICollection<Nota> consultarNotasAlunoDisciplina(Aluno alunoParam, Disciplina disciplinaParam)
        {
            ICollection<Nota> notasAlunoDisciplina = new List<Nota>();
            DbSet<Nota> notas = context.notas;
            DbSet<Aluno> alunos = context.alunos;
            DbSet<Turma> turmas = context.turmas;
            DbSet<Avaliacao> avaliacoes = context.avaliacoes;
            var consulta = from nota in notas
                            join aluno in alunos on nota.alunoId equals aluno.alunoId
                            join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                            join turma in turmas on avaliacao.turmaId equals turma.turmaId
                            where turma.disciplinaId == disciplinaParam.disciplinaId && aluno.alunoId == alunoParam.alunoId
                            select nota;
            notasAlunoDisciplina = consulta.ToList<Nota>();
            return notasAlunoDisciplina;
        }
        public ICollection<Nota> consultarNotasPeriodo(Periodo periodoParam)
        {
            ICollection<Nota> notasPeriodo = new List<Nota>();
            DbSet<Nota> notas = context.notas;
            DbSet<Turma> turmas = context.turmas;
            DbSet<Avaliacao> avaliacoes = context.avaliacoes;
            var consulta = from nota in notas
                            join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                            join turma in turmas on avaliacao.turmaId equals turma.turmaId
                            where turma.periodoId == periodoParam.periodoId
                            select nota;
            notasPeriodo = consulta.ToList<Nota>();
            return notasPeriodo;
        }

        public ICollection<Nota> consultarNotasAlunoPeriodo(Aluno alunoParam, Periodo periodoParam)
        {
            ICollection<Nota> notasAlunoPeriodo = new List<Nota>();
            DbSet<Nota> notas = context.notas;
            DbSet<Turma> turmas = context.turmas;
            DbSet<Aluno> alunos = context.alunos;
            DbSet<Avaliacao> avaliacoes = context.avaliacoes;
            var consulta = from nota in notas
                            join aluno in alunos on nota.alunoId equals aluno.alunoId
                            join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                            join turma in turmas on avaliacao.turmaId equals turma.turmaId
                            where turma.periodoId == periodoParam.periodoId && aluno.alunoId == alunoParam.alunoId
                            select nota;
            notasAlunoPeriodo = consulta.ToList<Nota>();
            return notasAlunoPeriodo;
        }
        public ICollection<Nota> consultarNotasIntervaloPeriodo(Aluno alunoParam, Periodo periodoInicio, Periodo periodoFim)
        {
            ICollection<Nota> notasAlunoPeriodo = new List<Nota>();
            DbSet<Nota> notas = context.notas;
            DbSet<Turma> turmas = context.turmas;
            DbSet<Aluno> alunos = context.alunos;
            DbSet<Avaliacao> avaliacoes = context.avaliacoes;
            DbSet<Periodo> periodos = context.periodos;
            var consulta = from nota in notas
                           join aluno in alunos on nota.alunoId equals aluno.alunoId
                           join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                           join turma in turmas on avaliacao.turmaId equals turma.turmaId
                           join periodo in periodos on turma.periodoId equals periodo.periodoId
                           where periodo.dataInicio >= periodoInicio.dataInicio && periodo.dataFim <= periodo.dataFim && aluno.alunoId == alunoParam.alunoId
                           select nota;
            notasAlunoPeriodo = consulta.ToList<Nota>();
            return notasAlunoPeriodo;
        }
        public ICollection<Nota> consultarNotasAlunoIntervaloPeriodo(Periodo periodoInicio, Periodo periodoFim)
        {
            ICollection<Nota> notasAlunoPeriodo = new List<Nota>();
            DbSet<Nota> notas = context.notas;
            DbSet<Turma> turmas = context.turmas;
            DbSet<Avaliacao> avaliacoes = context.avaliacoes;
            DbSet<Periodo> periodos = context.periodos;
            var consulta = from nota in notas
                            join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                            join turma in turmas on avaliacao.turmaId equals turma.turmaId
                            join periodo in periodos on turma.periodoId equals periodo.periodoId
                            where periodo.dataInicio >= periodoInicio.dataInicio && periodo.dataFim <= periodo.dataFim
                            select nota;
            notasAlunoPeriodo = consulta.ToList<Nota>();
           return notasAlunoPeriodo;
        }

        
        public ICollection<Nota> consultarNotasPorFiltros(int idCurso, int alunoMatricula, int idDisciplina, DateTime periodoInicio, DateTime periodoFim)
        {
            ICollection<Nota> notasAlunoPeriodo = new List<Nota>();
            var notas = context.notas;
            DbSet<Turma> turmas = context.turmas;
            DbSet<Avaliacao> avaliacoes = context.avaliacoes;
            DbSet<Periodo> periodos = context.periodos;
            DbSet<Aluno> alunos = context.alunos;
            DbSet<Disciplina> disciplinas = context.disciplinas;
            DbSet<Pessoa> pessoas = context.pessoas;
            DbSet<Matricula> matriculas = context.matriculas;
            DbSet<Curso> cursos = context.cursos;
            var consulta = (from nota in notas
                           join aluno in alunos on nota.alunoId equals aluno.alunoId
                           join curso in cursos on aluno.cursoId equals curso.cursoId
                           join pessoa in pessoas on aluno.pessoa.pessoaId equals pessoa.pessoaId
                           join matricula in matriculas on pessoa.pessoaId equals matricula.pessoaId
                           join avaliacao in avaliacoes on nota.avaliacaoId equals avaliacao.avaliacaoId
                           join turma in turmas on avaliacao.turmaId equals turma.turmaId
                           join disciplina in disciplinas on turma.disciplinaId equals disciplina.disciplinaId
                           join periodo in periodos on turma.periodoId equals periodo.periodoId
                           where
                                (periodoInicio == null || periodo.dataInicio >= periodoInicio) &&
                                (periodoFim == null || periodo.dataFim <= periodoFim) &&
                                (idDisciplina == 0 || disciplina.disciplinaId == idDisciplina) &&
                                (alunoMatricula == 0|| matricula.matriculaId == alunoMatricula) &&
                                (idCurso == 0 || curso.cursoId == idCurso)
                           orderby pessoa.nome
                           select nota).Include(nota => nota.avaliacao.turma.disciplina).Include(nota => nota.aluno);
            notasAlunoPeriodo = consulta.ToList<Nota>();
            return notasAlunoPeriodo;
        }

        public void salva()
        {
            this.context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}