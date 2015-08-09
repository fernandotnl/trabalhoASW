using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoASW.Controllers.Business;
using TrabalhoASW.Controllers.Business.ContextoBancoDados;
using TrabalhoASW.Models;

namespace TrabalhoASW.Controllers
{
    public class HomeController : Controller
    {
        NotaBusiness notaBusiness = new NotaBusiness();
        public ActionResult Index()
        {
            //CriaBanco cria = new CriaBanco(); // Descomentar para gerar o banco
            Aluno aluno = new Aluno();
            aluno.alunoId = 1;

            Turma turma = new Turma();
            turma.turmaId = 1;
            ICollection<Nota> notas = notaBusiness.consultarNotasAluno(aluno);
            ICollection<Nota> notas2 = notaBusiness.consultarNotasTurma(turma);
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