using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class PessoaRepository : BaseRepository<Pessoa>
    {
        public List<Pessoa> buscarTodos()
        {
            return new List<Pessoa>();
        }
    }
}