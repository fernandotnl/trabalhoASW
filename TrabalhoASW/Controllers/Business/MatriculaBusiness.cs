using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class MatriculaBusiness
    {
        MatriculaRepository repositorio;
        
        public MatriculaBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.MatriculaRepository;
        }

        public Matricula criaMatricula(String codigo, TipoMatricula tipoMatricula, Pessoa pessoa)
        {
            Matricula matricula1 = new Matricula();
            matricula1.codigo = codigo;
            matricula1.tipoMatricula = tipoMatricula;
            matricula1.pessoa = pessoa;
            return matricula1;
        }

        public void persisteMatriculas(List<Matricula> matriculas)
        {
            foreach (Matricula matricula in matriculas)
            {
                repositorio.context.matriculas.Add(matricula);
            }
            repositorio.salva();
        }

        public Matricula buscarMatriculaPorEmail(String email)
        {
            return repositorio.buscarMatriculaPorEmail(email);
        }
    }
}