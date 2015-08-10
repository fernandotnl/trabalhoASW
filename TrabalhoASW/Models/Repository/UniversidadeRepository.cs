using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models.Repository
{
    public class UniversidadeRepository : BaseRepository<Universidade>
    {
        public ContextoBD context { get; set; }
        private bool disposed = false;
        
        public UniversidadeRepository(ContextoBD contexto)
        {
            this.context = contexto;
        }
        public ICollection<Universidade> buscarTodos()
        {
            ICollection<Universidade> todasUniversidades;
            DbSet<Universidade> univeesidades = context.universidades;
            var consulta = from universidade in univeesidades
                           select universidade;
            todasUniversidades = consulta.ToList<Universidade>();
            return todasUniversidades;
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