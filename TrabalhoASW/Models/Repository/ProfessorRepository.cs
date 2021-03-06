﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models.Repository
{
    public class ProfessorRepository : BaseRepository<Professor>
    {
        public ContextoBD context { get; set; }
        private bool disposed = false;
        
        public ProfessorRepository(ContextoBD context)
        {
            this.context = context;
        }
        public ICollection<Professor> buscarTodos()
        {
            ICollection<Professor> todosProfessores = new List<Professor>();
            DbSet<Professor> professores = context.professores;
            var consulta = from professor in professores
                           select professor;
            todosProfessores = consulta.ToList<Professor>();
            return todosProfessores;
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