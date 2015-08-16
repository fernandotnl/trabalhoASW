using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class CursoBusiness
    {
        CursoRepository repositorio;

        public CursoBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.CursoRepository;
        }

        public Curso criaCurso(String nomeCurso, Universidade universidade)
        {
            Curso curso = new Curso();
            curso.nome = nomeCurso;
            curso.universidade = universidade;
            return curso;
        }

        public void persisteCursos(ICollection<Curso> cursos)
        {
            foreach (Curso curso in cursos)
            {
                repositorio.context.cursos.Add(curso);
            }
            repositorio.salva();
        }

        public void associaCursoCoordenador(Curso curso, Coordenador coordenador)
        {
           repositorio.context.cursos.Attach(curso);

            curso.coordenador = coordenador;
            curso.coordenadorId = coordenador.coordenadorId;

            repositorio.context.coordenadores.Attach(coordenador);

            coordenador.curso = curso;
            coordenador.cursoId = curso.cursoId;

            repositorio.context.Entry(curso).State = EntityState.Modified;
            repositorio.context.Entry(coordenador).State = EntityState.Modified;

            repositorio.salva();
        }

        public List<SelectListItem> BuscarTodos()
        {
            List<Curso> cursos = new List<Curso>();
            List<SelectListItem> listaRetorno = new List<SelectListItem>();

            cursos = repositorio.buscarTodos().ToList();

            foreach (var item in cursos)
            {
                listaRetorno.Add(new SelectListItem
                {
                    Value = item.cursoId.ToString(),
                    Text = item.nome
                });
            }

            return listaRetorno;

        }
    }
}