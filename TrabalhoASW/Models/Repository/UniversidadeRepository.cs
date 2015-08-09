using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class UniversidadeRepository : BaseRepository<Universidade>
    {
        public ICollection<Universidade> buscarTodos()
        {
            return new List<Universidade>();
        }
    }
}