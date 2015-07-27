using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class AlunoRepository: BaseRepository<Aluno>
    {
        public List<Aluno> buscarTodos()
        {
            return new List<Aluno>();
        }
    }
}