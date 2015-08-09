using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class TurmaBusiness
    {
        TurmaRepository repositorio;
        public TurmaBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.TurmaRepository;
        }
        public Turma criaTurma(String codigo, Disciplina disciplina, Professor professor, Periodo periodo, Turno turno)
        {
            Turma turma = new Turma();
            turma.codigo = codigo;
            turma.disciplina = disciplina;
            turma.periodo = periodo;
            turma.turno = turno;
            turma.professor = professor;
            return turma;
        }

        public void persisteTurmas(List<Turma> turmas)
        {
            foreach (Turma turma in turmas)
            {
                repositorio.context.turmas.Add(turma);
            }
            repositorio.salva();
        }
        public void associaTurmaAvaliacoes(Turma turma, List<Avaliacao> avaliacoes)
        {
           repositorio.context.turmas.Attach(turma);

            foreach (Avaliacao avaliacao in avaliacoes)
            {
                turma.avaliacoes.Add(avaliacao);
            }

            repositorio.context.Entry(turma).State = EntityState.Modified;

            repositorio.salva();
        }

        public void associaTurmaAlunos(Turma turma, List<Aluno> alunos)
        {
            repositorio.context.turmas.Attach(turma);

            foreach (Aluno aluno in alunos)
            {
                turma.alunos.Add(aluno);
            }

            repositorio.context.Entry(turma).State = EntityState.Modified;

            repositorio.salva();
        }
    }
}