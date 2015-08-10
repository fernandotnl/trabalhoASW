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
            return View();
        }
        public ActionResult CriarBanco()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            UniversidadeBusiness universidadeBusiness = new UniversidadeBusiness(unidadeDeTrabalho);
            ICollection<Universidade> universidades = universidadeBusiness.buscarTodos();
            if (universidades.Count > 0)
            {
                ViewBag.Message = "O banco já foi criado anteriormente.";
            }
            else
            {
                CriaBanco cria = new CriaBanco(unidadeDeTrabalho); 
                ViewBag.Message = "Banco criado com sucesso!";
            }
            return View();
        }


        public ActionResult ConsultaNotas_aluno()
        {
            ViewBag.Message = "Página de consulta do aluno.";

            return View();
        }

        public ActionResult ConsultaNotas_coordenador()
        {
            ViewBag.Message = "Página de consulta do coordenador.";

            return View();
        }

        public ActionResult ConsultaNotas_secretario()
        {
            ViewBag.Message = "Página de consulta do secretario.";

            return View();
        }
    }
}