using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoASW.Controllers.Business;
using TrabalhoASW.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Owin;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public HomeController()
        {
            
        }

        public HomeController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        

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
                UsuarioBusiness usuarioBusiness = new UsuarioBusiness(UserManager);
                usuarioBusiness.criarBancoUsuarios();
                BancoDadosBusiness banco = new BancoDadosBusiness(unidadeDeTrabalho); 
                ViewBag.Message = "Banco criado com sucesso!";
            }
            return View();
        }

        [Authorize(Roles="Aluno")]
        public ActionResult ConsultaNotas_aluno()
        {
            ViewBag.Message = "Página de consulta do aluno.";

            return View();
        }
        [Authorize(Roles = "Coordenador")]
        public ActionResult ConsultaNotas_coordenador()
        {
            ViewBag.Message = "Página de consulta do coordenador.";

            return View();
        }
        [Authorize(Roles = "Secretario")]
        public ActionResult ConsultaNotas_secretario()
        {
            ViewBag.Message = "Página de consulta do secretario.";

            return View();
        }
    }
}