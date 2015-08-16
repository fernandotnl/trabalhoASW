using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models.Repository
{
    public class AlunoRepository: BaseRepository<Aluno>
    {
        public ContextoBD context { get; set; }
        private bool disposed = false;
       
        public AlunoRepository(ContextoBD context)
        {
            this.context = context;
        }
        public ICollection<Aluno> buscarTodos()
        {
            ICollection<Aluno> todosAlunos = new List<Aluno>();
            DbSet<Aluno> alunos = context.alunos;
            var consulta = from aluno in alunos
                           select aluno;
            todosAlunos = consulta.ToList<Aluno>();
            return todosAlunos;
        }
        public Aluno buscarAlunoPorEmail(String email)
        {
            DbSet<Aluno> alunos = context.alunos;
            DbSet<Pessoa> pessoas = context.pessoas;
            var consulta = (from aluno in alunos
                           join pessoa in pessoas on aluno.pessoa.pessoaId equals pessoa.pessoaId
                           where pessoa.email == email
                           select aluno);
            return consulta.FirstOrDefault();
        }
        public void salva()
        {
            this.context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}