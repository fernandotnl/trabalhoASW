using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class CoordenadorBusiness
    {
        CoordenadorRepository repositorio;

        public CoordenadorBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.CoordenadorRepository;
        }
        public Coordenador criaCoordenador(Curso curso, Pessoa pessoa)
        {
            Coordenador coordenador = new Coordenador();
            coordenador.curso = curso;
            coordenador.pessoa = pessoa;
            return coordenador;
        }

        public void persisteCoordenadores(List<Coordenador> coordenadores)
        {
            foreach (Coordenador coordenador in coordenadores)
            {
                repositorio.context.coordenadores.Add(coordenador);
            }
            repositorio.salva();
        }
    }
}