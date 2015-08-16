using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class AlunoBusiness
    {
        AlunoRepository repositorio;
        public AlunoBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.AlunoRepository;
        }

        public Aluno criaAluno(Curso curso, Pessoa pessoa)
        {
            Aluno aluno = new Aluno();
            aluno.curso = curso;
            aluno.pessoa = pessoa;
            return aluno;
        }

        public void persisteAlunos(List<Aluno> alunos)
        {
           foreach (Aluno aluno in alunos)
           {
                repositorio.context.alunos.Add(aluno);
           }
           repositorio.salva();
        }
        public ICollection<Aluno> buscarTodos()
        {
            return repositorio.buscarTodos();
        }

        public Aluno buscarAlunoPorEmail(String emailAluno)
        {
            return repositorio.buscarAlunoPorEmail(emailAluno);
        }
    }
}