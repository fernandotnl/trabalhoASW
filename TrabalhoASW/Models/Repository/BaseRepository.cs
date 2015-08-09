using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoASW.Models.Repository
{
    public interface BaseRepository<E> : IDisposable
    {
        ICollection<E> buscarTodos();
        void salva();
    }
}
