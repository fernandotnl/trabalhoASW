using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class ProfessorRepository : BaseRepository<Professor>
    {
        public List<Professor> buscarTodos()
        {
            return new List<Professor>();
        }
    }
}