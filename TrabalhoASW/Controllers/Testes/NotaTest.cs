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
        [Test]
        public void criaNotaTestTest()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Models.Aluno aluno = new Models.Aluno();
            Models.Avaliacao avaliacao = new Models.Avaliacao();

            Assert.Throws<Exception>(() => notaBusiness.criaNota(aluno, 100,  avaliacao));
        }

        [Test]
        public void persisteNotasTest()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            List<Models.Nota> notas = new List<Models.Nota>();

            Assert.Throws<Exception>(() => notaBusiness.persisteNotas(notas));
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
            Aluno alunoParam = new Aluno();

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasAluno(alunoParam));
        }

        [Test]
        public void consultarNotasTurmaTest()
        {
            Turma turmaParam = new Turma();

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasTurma(turmaParam));
        }

        [Test]
        public void consultarNotasAlunoTurmaTest()
        {
            Turma turmaParam = new Turma();
            Aluno alunoParam = new Aluno();

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasAlunoTurma(alunoParam,turmaParam));
        }

        [Test]
        public void consultarNotasDisciplinaTest()
        {
            Disciplina disciplinaParam = new Disciplina();

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasDisciplina(disciplinaParam));
        }

        [Test]
        public void consultarNotasAlunoDisciplinaTest()
        {
            Aluno alunoParam = new Aluno();
            Disciplina disciplinaParam = new Disciplina();
            
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasAlunoDisciplina(alunoParam, disciplinaParam));
        }

        [Test]
        public void consultarNotasPeriodoTest()
        {
            Periodo periodoParam = new Periodo();

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasPeriodo(periodoParam));
        }

        [Test]
        public void consultarNotasAlunoPeriodoTest()
        {

            Aluno alunoParam = new Aluno();
            Periodo periodoParam = new Periodo();
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            Assert.IsNotEmpty(notaBusiness.consultarNotasAlunoPeriodo(alunoParam, periodoParam));
        }
    }
}