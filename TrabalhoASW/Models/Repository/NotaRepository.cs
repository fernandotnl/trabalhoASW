using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class NotaRepository : BaseRepository<Nota>
    {
        public List<Nota> buscarTodos()
        {
            return new List<Nota>();
        }
    }
}