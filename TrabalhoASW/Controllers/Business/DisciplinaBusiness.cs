using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class DisciplinaBusiness
    {
        DisciplinaRepository repositorio;
        public DisciplinaBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.DisciplinaRepository;
        }

        public Disciplina criaDisciplina(string codigo, string nome)
        {
            Disciplina disciplina = new Disciplina();
            disciplina.codigo = codigo;
            disciplina.nome = nome;
            return disciplina;
        }

        public void persisteDisciplinas(List<Disciplina> disciplinas)
        {
            foreach (Disciplina disciplina in disciplinas)
            {
                repositorio.context.disciplinas.Add(disciplina);
            }
            repositorio.salva();
        }

        public List<SelectListItem> BuscarTodos()
        {
            List<Disciplina> disciplinas = new List<Disciplina>();
            List<SelectListItem> listaRetorno = new List<SelectListItem>();

            disciplinas = repositorio.buscarTodos().ToList();

            foreach (var item in disciplinas)
            {
                listaRetorno.Add(new SelectListItem
                {
                    Value = item.disciplinaId.ToString(),
                    Text = item.nome
                });
            }

            return listaRetorno;
        }
    }
}