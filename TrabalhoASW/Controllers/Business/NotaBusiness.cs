using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.repository;

namespace TrabalhoASW.Controllers.Business
{
    public class NotaBusiness
    {
        NotaRepository repositorio = new NotaRepository();


        public ICollection<Nota> consultarNotasAluno(Aluno alunoParam)
        {
            return repositorio.consultarNotasAluno(alunoParam);
        }

        public ICollection<Nota> consultarNotasTurma(Turma turmaParam)
        {
            return repositorio.consultarNotasTurma(turmaParam);
        }
    }
}