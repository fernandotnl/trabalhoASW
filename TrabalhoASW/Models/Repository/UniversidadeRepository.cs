using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class UniversidadeRepository : BaseRepository<Universidade>
    {
        public List<Universidade> buscarTodos()
        {
            return new List<Universidade>();
        }
    }
}