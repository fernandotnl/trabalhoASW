using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoASW.Controllers.Business;
using TrabalhoASW.Controllers.Business.ContextoBancoDados;
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

        public HomeController()
        {
            
        }

        public HomeController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public void criarBancoUsuarios()
        {
            criarRoles();

            RegisterViewModel aluno = new RegisterViewModel();
            aluno.Email = "aluno@email.com";
            aluno.Password = "Teste@1234";
            criarUsuario(aluno, "Aluno");

            RegisterViewModel secretario = new RegisterViewModel();
            secretario.Email = "secretario@email.com";
            secretario.Password = "Teste@1234";
            criarUsuario(secretario, "Secretario");

            RegisterViewModel coordenador = new RegisterViewModel();
            coordenador.Email = "coordenador@email.com";
            coordenador.Password = "Teste@1234";
            criarUsuario(coordenador, "Coordenador");
       }

        public void criarRoles()
        {
             var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(ApplicationDbContext.Create()));
             RoleManager.Create(new IdentityRole("Aluno"));
             RoleManager.Create(new IdentityRole("Coordenador"));
             RoleManager.Create(new IdentityRole("Secretario"));
        }

        private void criarUsuario(RegisterViewModel model, string role)
        {
            var user1 = new ApplicationUser() { UserName = model.Email, Email = model.Email };
            IdentityResult result1 = UserManager.Create(user1, model.Password);
            if (result1.Succeeded)
            {
               ;
                UserManager.AddToRole(user1.Id, role);
            }
            else
            {
                //AddErrors(result);
            }
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
                criarBancoUsuarios();
                CriaBanco cria = new CriaBanco(unidadeDeTrabalho); 
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