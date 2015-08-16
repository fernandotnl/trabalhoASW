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
using TrabalhoASW.ViewModel;

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
                BancoDadosBusiness banco = new BancoDadosBusiness(unidadeDeTrabalho); 
                
                UsuarioBusiness usuarioBusiness = new UsuarioBusiness(UserManager);
                usuarioBusiness.criarRoles();

                AlunoBusiness alunoBusiness = new AlunoBusiness(unidadeDeTrabalho);
                ICollection<Aluno> alunos = alunoBusiness.buscarTodos();
                usuarioBusiness.criarUsuariosAlunos(alunos);

                ProfessorBusiness professorBusiness = new ProfessorBusiness(unidadeDeTrabalho);
                ICollection<Professor> professores = professorBusiness.buscarTodos();
                usuarioBusiness.criarUsuariosProfessores(professores);

                CoordenadorBusiness coordenadorBusiness = new CoordenadorBusiness(unidadeDeTrabalho);
                ICollection<Coordenador> coordenadores = coordenadorBusiness.buscarTodos();
                usuarioBusiness.criarUsuariosCoordenadores(coordenadores);
                ViewBag.Message = "Banco criado com sucesso!";
            }
            return View();
        }

        [Authorize(Roles="Aluno")]
        public ActionResult ConsultaNotas_aluno()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            CursoBusiness cursoBusiness = new CursoBusiness(unidadeDeTrabalho);
            DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness(unidadeDeTrabalho);

            ViewBag.Disciplinas = disciplinaBusiness.BuscarTodos();
            ViewBag.Cursos = cursoBusiness.BuscarTodos();
            ViewBag.Notas = new List<Nota>();

            return View();
        }

        [Authorize(Roles = "Aluno")]
        [HttpPost]
        public ActionResult ConsultaNotas_aluno(AlunoModel viewModel)
        {

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            CursoBusiness cursoBusiness = new CursoBusiness(unidadeDeTrabalho);
            DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness(unidadeDeTrabalho);
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            DateTime dataInicio = DateTime.MinValue;
            DateTime dataFim = DateTime.MaxValue;
            if (viewModel.DataInicio != null)
                dataInicio = DateTime.ParseExact(viewModel.DataInicio, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
            if (viewModel.DataFim != null)
                dataFim = DateTime.ParseExact(viewModel.DataFim, "dd/MM/yyyy",
                                           System.Globalization.CultureInfo.InvariantCulture);

            var nomeUsuario = HttpContext.GetOwinContext().Authentication.User.Identity.GetUserName();

            MatriculaBusiness matriculaBusiness = new MatriculaBusiness(unidadeDeTrabalho);
            Int32 matriculaId = matriculaBusiness.buscarMatriculaPorEmail(nomeUsuario).matriculaId;

            List<Nota> notas = notaBusiness.consultarNotasPorFiltros(0, matriculaId, viewModel.Disciplina, dataInicio, dataFim).ToList();

            ViewBag.Notas = notas;
            ViewBag.Disciplinas = disciplinaBusiness.BuscarTodos();
            ViewBag.Cursos = cursoBusiness.BuscarTodos();

            return View();
        }

        [Authorize(Roles = "Coordenador")]
        public ActionResult ConsultaNotas_coordenador()
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            CursoBusiness cursoBusiness = new CursoBusiness(unidadeDeTrabalho);
            DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness(unidadeDeTrabalho);

            ViewBag.Disciplinas = disciplinaBusiness.BuscarTodos();
            ViewBag.Cursos = cursoBusiness.BuscarTodos();
            ViewBag.Notas = new List<Nota>();

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Coordenador")]
        public ActionResult ConsultaNotas_coordenador(CoordenadorModel viewModel)
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            CursoBusiness cursoBusiness = new CursoBusiness(unidadeDeTrabalho);
            DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness(unidadeDeTrabalho);
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);
            DateTime dataInicio = DateTime.MinValue;
            DateTime dataFim = DateTime.MaxValue;
            if (viewModel.DataInicio != null)
                dataInicio = DateTime.ParseExact(viewModel.DataInicio, "dd/MM/yyyy",
                                        System.Globalization.CultureInfo.InvariantCulture);
            if (viewModel.DataFim != null)
                dataFim = DateTime.ParseExact(viewModel.DataFim, "dd/MM/yyyy",
                                            System.Globalization.CultureInfo.InvariantCulture);
            List<Nota> notas = notaBusiness.consultarNotasPorFiltros(viewModel.Curso, viewModel.Aluno, viewModel.Disciplina, dataInicio, dataFim).ToList();

            ViewBag.Notas = notas;
            ViewBag.Disciplinas = disciplinaBusiness.BuscarTodos();
            ViewBag.Cursos = cursoBusiness.BuscarTodos();

            return View();
        }

        [Authorize(Roles = "Secretario")]
        public ActionResult ConsultaNotas_secretario()
        {
            ViewBag.Erro = false;

            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            CursoBusiness cursoBusiness = new CursoBusiness(unidadeDeTrabalho);
            DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness(unidadeDeTrabalho);

            ViewBag.Disciplinas = disciplinaBusiness.BuscarTodos();
            ViewBag.Cursos = cursoBusiness.BuscarTodos();
            ViewBag.Notas = new List<Nota>();

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Secretario")]
        public ActionResult ConsultaNotas_secretario(SecretariaModel viewModel)
        {
            UnidadeDeTrabalho unidadeDeTrabalho = new UnidadeDeTrabalho();
            CursoBusiness cursoBusiness = new CursoBusiness(unidadeDeTrabalho);
            DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness(unidadeDeTrabalho);
            NotaBusiness notaBusiness = new NotaBusiness(unidadeDeTrabalho);

            DateTime dataInicio = DateTime.MinValue;
            DateTime dataFim = DateTime.MaxValue;
            if (viewModel.DataInicio != null)
                dataInicio = DateTime.ParseExact(viewModel.DataInicio, "dd/MM/yyyy",
                                        System.Globalization.CultureInfo.InvariantCulture);
            if (viewModel.DataFim != null)
                dataFim = DateTime.ParseExact(viewModel.DataFim, "dd/MM/yyyy",
                                            System.Globalization.CultureInfo.InvariantCulture);
            List<Nota> notas = notaBusiness.consultarNotasPorFiltros(viewModel.Curso, viewModel.Aluno, viewModel.Disciplina, dataInicio, dataFim).ToList();


            ViewBag.Notas = notas;
            ViewBag.Disciplinas = disciplinaBusiness.BuscarTodos();
            ViewBag.Cursos = cursoBusiness.BuscarTodos();

            return View();
        }
    }
}