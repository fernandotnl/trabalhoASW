using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class PeriodoBusiness
    {
        PeriodoRepository repositorio;
        public PeriodoBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.PeriodoRepository;
        }

        public Periodo criaPeriodo(DateTime dataInicio, DateTime dataFim, string nome)
        {
            Periodo periodo = new Periodo();
            periodo.dataInicio = dataInicio;
            periodo.dataFim = dataFim;
            periodo.nome = nome;
            return periodo;
        }

        public void persistePeriodos(List<Periodo> periodos)
        {
            foreach (Periodo periodo in periodos)
            {
                repositorio.context.periodos.Add(periodo);
            }
            repositorio.salva();
        }
    }
}