using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class PeriodoRepository : BaseRepository<Periodo>
    {
        public ICollection<Periodo> buscarTodos()
        {
            return new List<Periodo>();
        }
    }
}