using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models.Repository
{
    public class MatriculaRepository : BaseRepository<Matricula>
    {
        public ContextoBD context { get; set; }
        private bool disposed = false;
        
        public MatriculaRepository(ContextoBD context)
        {
            this.context = context;
        }
        public ICollection<Matricula> buscarTodos()
        {
            return new List<Matricula>();
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

        public Matricula buscarMatriculaPorEmail(String email)
        {
            ICollection<Aluno> resultAlunos = new List<Aluno>();
            DbSet<Aluno> alunos = context.alunos;
            DbSet<Pessoa> pessoas = context.pessoas;
            DbSet<Matricula> matriculas = context.matriculas;
            var consulta = from matricula in matriculas
                            join pessoa in pessoas on matricula.pessoaId equals pessoa.pessoaId
                            where pessoa.email == email
                            select matricula;
            return consulta.FirstOrDefault();
        }
    }
}