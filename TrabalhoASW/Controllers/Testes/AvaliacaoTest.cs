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
    public class AvaliacaoTest
    {
        [Test]
        public void criarAvaliacao()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            AvaliacaoBusiness avaliacaoBusiness = new AvaliacaoBusiness(unidadeDeTrabalho);
            Models.Turma turma = new Models.Turma();

            Assert.Throws<Exception>(() => avaliacaoBusiness.criaAvaliacao("", turma));
        }

        [Test]
        public void persisteAvaliacoes()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            AvaliacaoBusiness avaliacaoBusiness = new AvaliacaoBusiness(unidadeDeTrabalho);
            List<Models.Avaliacao> avaliacao = new List<Models.Avaliacao>();

            Assert.Throws<Exception>(() => avaliacaoBusiness.persisteAvaliacoes(avaliacao));
        }
    }
}