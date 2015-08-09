using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models.Repository
{
    public class PeriodoRepository : BaseRepository<Periodo>
    {
        public ContextoBD context { get; set; }
        private bool disposed = false;
        
        public PeriodoRepository(ContextoBD context)
        {
            this.context = context;
        }
        public ICollection<Periodo> buscarTodos()
        {
            return new List<Periodo>();
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