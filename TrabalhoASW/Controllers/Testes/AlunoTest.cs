using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Controllers.Business;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Testes
{
    [TestFixture]
    public class AlunoTest
    {
        [Test]
        public void criaAlunoTest()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            Models.Curso curso = new Models.Curso();
            Models.Pessoa pessoa = new Models.Pessoa();
            AlunoBusiness alunoBusiness = new AlunoBusiness(unidadeDeTrabalho);

            Assert.Throws<Exception>(() => alunoBusiness.criaAluno(curso, pessoa));
        }

        [Test]
        public void persisteAlunos()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            AlunoBusiness alunoBusiness = new AlunoBusiness(unidadeDeTrabalho);
            List<Models.Aluno> aluno = new List<Models.Aluno>();

            Assert.Throws<Exception>(() => alunoBusiness.persisteAlunos(aluno));
        }
    }
}