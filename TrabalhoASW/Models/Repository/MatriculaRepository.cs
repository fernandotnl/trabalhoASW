using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class MatriculaRepository : BaseRepository<Matricula>
    {
        public List<Matricula> buscarTodos()
        {
            return new List<Matricula>();
        }
    }
}