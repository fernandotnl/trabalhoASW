using System;
using System.Collections.Generic;
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
            return new List<Aluno>();
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