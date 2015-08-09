using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models.Repository
{
    public class AvaliacaoRepository: BaseRepository<Avaliacao>
    {
        public ContextoBD context { get; set; }
        private bool disposed = false;
        
        public AvaliacaoRepository(ContextoBD context)
        {
            this.context = context;
        }
        public ICollection<Avaliacao> buscarTodos()
        {
            return new List<Avaliacao>();
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