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

        public ICollection<Nota> buscarTodos()
        {
            return repositorio.buscarTodos();
        }
        public ICollection<Nota> consultarNotasAluno(Aluno alunoParam)
        {
            return repositorio.consultarNotasAluno(alunoParam);
        }

        public ICollection<Nota> consultarNotasTurma(Turma turmaParam)
        {
            return repositorio.consultarNotasTurma(turmaParam);
        }

        public ICollection<Nota> consultarNotasAlunoTurma(Aluno alunoParam, Turma turmaParam)
        {
            return repositorio.consultarNotasAlunoTurma(alunoParam, turmaParam);
        }

        public ICollection<Nota> consultarNotasDisciplina(Disciplina disciplinaParam)
        {
            return repositorio.consultarNotasDisciplina(disciplinaParam);
        }

        public ICollection<Nota> consultarNotasAlunoDisciplina(Aluno alunoParam, Disciplina disciplinaParam)
        {
            return repositorio.consultarNotasAlunoDisciplina(alunoParam, disciplinaParam);
        }
        public ICollection<Nota> consultarNotasPeriodo(Periodo periodoParam)
        {
            return repositorio.consultarNotasPeriodo(periodoParam);
        }

        public ICollection<Nota> consultarNotasAlunoPeriodo(Aluno alunoParam, Periodo periodoParam)
        {
            return repositorio.consultarNotasAlunoPeriodo(alunoParam, periodoParam);
        }
    }
}