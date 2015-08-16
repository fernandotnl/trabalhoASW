using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Controllers.Business;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Testes
{
    [TestFixture]
    public class NotaTest
    {
        private Aluno MockAluno()
        {
            Aluno aluno = new Aluno();
            aluno.alunoId = 1;
            aluno.cursoId = 1;

            Pessoa pessoa = new Pessoa();
            pessoa.pessoaId = 1;
            aluno.pessoa = pessoa;

            return aluno;
        }

        private Periodo MockPeriodo()
        {
            Periodo periodo = new Periodo();
            periodo.periodoId = 1;
            periodo.nome = "";
            periodo.dataInicio = DateTime.Now;
            periodo.dataFim = DateTime.Now;

            return periodo;
        }

        private Disciplina MockDisciplina()
        {
            Disciplina disciplina = new Disciplina();
            disciplina.disciplinaId = 1;
            disciplina.codigo = "abc";
            disciplina.nome = "PROGRAMACAO";

            return disciplina;
        }

        private Nota MockNota()
        {
            Nota nota = new Nota();

            nota.notaId = 1;
            nota.aluno = MockAluno();
            nota.avaliacao = MockAvaliacao();

            return nota;
        }

        private Avaliacao MockAvaliacao()
        {
            Avaliacao avaliacao = new Avaliacao();

            avaliacao.avaliacaoId = 1;
            avaliacao.turmaId = 1;
            avaliacao.nome = "";
            avaliacao.turma = MockTurma();

            return avaliacao;
        }

        private Turma MockTurma()
        {
            Turma turma = new Turma();

            turma.turmaId = 1;
            turma.codigo = "";
            turma.turmaId = 1;
            turma.periodoId = 1;
            turma.periodo = MockPeriodo();
            turma.professorId = 1;
            turma.disciplinaId = 1;
            turma.disciplina = MockDisciplina();

            return new Turma();
        }

        [Test]
        public void criaNotaTestTest()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Models.Aluno aluno = MockAluno();
            Models.Avaliacao avaliacao = MockAvaliacao();

            Assert.Throws<Exception>(() => notaBusiness.criaNota(aluno, 100, avaliacao));
        }

        [Test]
        public void buscarTodosTest()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.Throws<Exception>(() => notaBusiness.buscarTodos());
        }

        [Test]
        public void consultarNotasAlunoTest()
        {
            Aluno alunoParam = MockAluno();

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasAluno(alunoParam));
        }

        [Test]
        public void consultarNotasTurmaTest()
        {
            Turma turmaParam = MockTurma();

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasTurma(turmaParam));
        }

        [Test]
        public void consultarNotasAlunoTurmaTest()
        {
            Turma turmaParam = MockTurma();
            Aluno alunoParam = MockAluno();

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasAlunoTurma(alunoParam, turmaParam));
        }

        [Test]
        public void consultarNotasDisciplinaTest()
        {
            Disciplina disciplinaParam = MockDisciplina();

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasDisciplina(disciplinaParam));
        }

        [Test]
        public void consultarNotasAlunoDisciplinaTest()
        {
            Aluno alunoParam = MockAluno();
            Disciplina disciplinaParam = MockDisciplina();

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasAlunoDisciplina(alunoParam, disciplinaParam));
        }

        [Test]
        public void consultarNotasPeriodoTest()
        {
            Periodo periodoParam = MockPeriodo();

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasPeriodo(periodoParam));
        }

        [Test]
        public void consultarNotasAlunoPeriodoTest()
        {
            Aluno alunoParam = MockAluno();
            Periodo periodoParam = MockPeriodo();
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasAlunoPeriodo(alunoParam, periodoParam));
        }
    }
}