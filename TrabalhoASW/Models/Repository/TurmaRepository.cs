using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class TurmaRepository : BaseRepository<Turma>
    {
        public List<Turma> buscarTodos()
        {
            return new List<Turma>();
        }
    }
}