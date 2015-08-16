using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class NotaBusiness
    {
        NotaRepository repositorio;
        public NotaBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.NotaRepository;
        }

        public Nota criaNota(Aluno aluno, double valor, Avaliacao avaliacao)
        {
            Nota nota = new Nota();
            nota.aluno = aluno;
            nota.valor = valor;
            nota.avaliacao = avaliacao;
            nota.avaliacao.notas.Add(nota);

            avaliacao.notas.Add(nota);
            return nota;
        }

        public void persisteNotas(List<Nota> notas)
        {
            //List<Avaliacao> avaliacoes = new List<Avaliacao>();
            foreach (Nota nota in notas)
            {
                //Avaliacao avaliacao = nota.avaliacao;
                repositorio.context.notas.Add(nota);
                //avaliacao.notas.Add(nota);
                //repositorio.context.Entry(avaliacao).State = EntityState.Modified;
            }
        }

        public ICollection<Nota> buscarTodos()
        {
            return repositorio.buscarTodos();
        }
        public ICollection<Nota> consultarNotasAluno(Aluno alunoParam)
        {
            return repositorio.consultarNotasAluno(alunoParam);
        }

        public ICollection<Nota> consultarNotasTurma(Turma turmaParam)
        {
            return repositorio.consultarNotasTurma(turmaParam);
        }

        public ICollection<Nota> consultarNotasAlunoTurma(Aluno alunoParam, Turma turmaParam)
        {
            return repositorio.consultarNotasAlunoTurma(alunoParam, turmaParam);
        }

        public ICollection<Nota> consultarNotasDisciplina(Disciplina disciplinaParam)
        {
            return repositorio.consultarNotasDisciplina(disciplinaParam);
        }

        public ICollection<Nota> consultarNotasAlunoDisciplina(Aluno alunoParam, Disciplina disciplinaParam)
        {
            return repositorio.consultarNotasAlunoDisciplina(alunoParam, disciplinaParam);
        }
        public ICollection<Nota> consultarNotasPeriodo(Periodo periodoParam)
        {
            return repositorio.consultarNotasPeriodo(periodoParam);
        }

        public ICollection<Nota> consultarNotasAlunoPeriodo(Aluno alunoParam, Periodo periodoParam)
        {
            return repositorio.consultarNotasAlunoPeriodo(alunoParam, periodoParam);
        }

        public ICollection<Nota> consultarNotasPorFiltros(String nomeCurso, String nomeAluno, String nomeDisciplina, DateTime periodoInicio, DateTime periodoFim)
        {
            return repositorio.consultarNotasPorFiltros(nomeCurso, nomeAluno, nomeDisciplina, periodoInicio, periodoFim);
        }
        
    }
}