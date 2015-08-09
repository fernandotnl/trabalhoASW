using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoASW.Controllers.Business;
using TrabalhoASW.Controllers.Business.ContextoBancoDados;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            CriaBanco cria = new CriaBanco(unidadeDeTrabalho); // Descomentar para gerar o banco e comentar após gerar o banco
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);
            /*Aluno aluno = new Aluno();
            aluno.alunoId = 1;

            Turma turma = new Turma();
            turma.turmaId = 1;
            ICollection<Nota> notas = notaBusiness.consultarNotasAluno(aluno);
            ICollection<Nota> notas2 = notaBusiness.consultarNotasTurma(turma);
            ICollection<Nota> notas3 = notaBusiness.consultarNotasAlunoTurma(aluno, turma);*/
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}