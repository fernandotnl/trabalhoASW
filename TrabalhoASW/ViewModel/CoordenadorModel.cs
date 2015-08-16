using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrabalhoASW.ViewModel
{
    public class CoordenadorModel
    {
        public Int32 Curso { get; set; }

        public Int32 Disciplina { get; set; }

        [DisplayFormat(DataFormatString = "99/99/9999")]
        public String DataInicio { get; set; }

        [DisplayFormat(DataFormatString = "99/99/9999")]
        public String DataFim { get; set; }

        public Int32 Aluno { get; set; }

        public Int32 Matricula { get; set; }
    }
}