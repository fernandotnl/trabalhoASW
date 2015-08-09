using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class AvaliacaoBusiness
    {
        AvaliacaoRepository repositorio;
        public AvaliacaoBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.AvaliacaoRepository;
        }
        public Avaliacao criaAvaliacao(string nome, Turma turma)
        {
            Avaliacao avaliacao = new Avaliacao();
            avaliacao.nome = nome;
            avaliacao.turma = turma;
            return avaliacao;
        }

        public void persisteAvaliacoes(List<Avaliacao> avaliacoes)
        {
            foreach (Avaliacao avaliacao in avaliacoes)
            {
                repositorio.context.avaliacoes.Add(avaliacao);
            }
            repositorio.salva();
        }
    }
}