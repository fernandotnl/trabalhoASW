using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class EnderecoRepository : BaseRepository<Endereco>
    {
        public List<Endereco> buscarTodos()
        {
            return new List<Endereco>();
        }
    }
}