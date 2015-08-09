using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class CursoRepository : BaseRepository<Curso>
    {
        public ICollection<Curso> buscarTodos()
        {
            return new List<Curso>();
        }
    }
}