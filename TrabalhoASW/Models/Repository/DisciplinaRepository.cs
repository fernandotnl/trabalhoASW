using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models.Repository
{
    public class DisciplinaRepository : BaseRepository<Disciplina>
    {
        public ContextoBD context { get; set; }
        private bool disposed = false;
        
        public DisciplinaRepository(ContextoBD context)
        {
            this.context = context;
        }

        public ICollection<Disciplina> buscarTodos()
        {
            return this.context.disciplinas.ToList();
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