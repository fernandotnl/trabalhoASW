using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Owin;

namespace TrabalhoASW.Controllers.Business
{
    public class UsuarioBusiness
    {
        private ApplicationUserManager _userManager;

        public UsuarioBusiness(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager;
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

        public void criarUsuariosAlunos(ICollection<Aluno> alunos)
        {
            foreach (Aluno aluno in alunos)
            {
                RegisterViewModel alunoUsuario = new RegisterViewModel();
                alunoUsuario.Email = aluno.pessoa.email;
                alunoUsuario.Password = "Teste@1234";
                //alunoUsuario.pessoa = aluno.pessoa;
                criarUsuario(alunoUsuario, "Aluno");

            }
        }

        public void criarUsuariosProfessores(ICollection<Professor> professores)
        {

            foreach (Professor professor in professores)
            {
                RegisterViewModel secretarioUsuario = new RegisterViewModel();
                secretarioUsuario.Email = professor.pessoa.email;
                secretarioUsuario.Password = "Teste@1234";
                //secretarioUsuario.pessoa = professor.pessoa;
                criarUsuario(secretarioUsuario, "Secretario");
            }
        }

        public void criarUsuariosCoordenadores(ICollection<Coordenador> coordenadores)
        {

            foreach (Coordenador coordenador in coordenadores)
            {
                RegisterViewModel coordenadorUsuario = new RegisterViewModel();
                coordenadorUsuario.Email = coordenador.pessoa.email;
                coordenadorUsuario.Password = "Teste@1234";
                //coordenadorUsuario.pessoa = coordenador.pessoa;
                criarUsuario(coordenadorUsuario, "Coordenador");
            }
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
            var user1 = new ApplicationUser() { UserName = model.Email, Email = model.Email  };
            //var user1 = new ApplicationUser() { UserName = model.Email, Email = model.Email, Pessoa = model.pessoa };
            IdentityResult result1 = UserManager.Create(user1, model.Password);
            if (result1.Succeeded)
            {
                UserManager.AddToRole(user1.Id, role);
            }
            else
            {
                //AddErrors(result);
            }
        }
    }
}