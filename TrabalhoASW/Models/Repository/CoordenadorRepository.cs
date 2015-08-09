using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class CoordenadorRepository: BaseRepository<Coordenador>
    {
        public ICollection<Coordenador> buscarTodos()
        {
            return new List<Coordenador>();
        }
    }
}