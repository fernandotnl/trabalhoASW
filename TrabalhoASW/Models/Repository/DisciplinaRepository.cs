﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Models.repository
{
    public class DisciplinaRepository : BaseRepository<Disciplina>
    {
        public List<Disciplina> buscarTodos()
        {
            return new List<Disciplina>();
        }
    }
}