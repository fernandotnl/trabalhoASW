using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class ProfessorBusiness
    {
        ProfessorRepository repositorio;

        public ProfessorBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.ProfessorRepository;
        }

        public Professor criaProfessor(Curso curso, Pessoa pessoa)
        {
            Professor professor = new Professor();
            professor.curso = curso;
            professor.pessoa = pessoa;
            return professor;
        }

        public void persisteProfessores(List<Professor> professores)
        {
           foreach (Professor professor in professores)
           {
                repositorio.context.professores.Add(professor);
           }
           repositorio.salva();
        }

        public ICollection<Professor> buscarTodos()
        {
            return repositorio.buscarTodos();
        }
    }
}