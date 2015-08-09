using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoASW.Controllers.Business.ContextoBancoDados;
using TrabalhoASW.Models;

namespace TrabalhoASW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CriaBanco cria = new CriaBanco();
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