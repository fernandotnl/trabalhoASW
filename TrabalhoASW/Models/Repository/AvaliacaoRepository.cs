using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class AvaliacaoRepository: BaseRepository<Avaliacao>
    {
        public ICollection<Avaliacao> buscarTodos()
        {
            return new List<Avaliacao>();
        }
    }
}