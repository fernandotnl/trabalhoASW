using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class UniversidadeBusiness
    {
        UniversidadeRepository repositorio;

        public UniversidadeBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.UniversidadeRepository;
        }

        public Universidade criaUniversidade(String nome)
        {
            Universidade universidade = new Universidade();
            universidade.nome = nome;
            return universidade;
        }

        public void persisteUniversidades(ICollection<Universidade> universidades)
        {
            foreach (Universidade universidade in universidades)
            {
                repositorio.context.universidades.Add(universidade);
            }
        }
    }
}