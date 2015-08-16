using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrabalhoASW.ViewModel
{
    public class CoordenadorModel
    {
        public String Curso { get; set; }

        public String Disciplina { get; set; }

        [DisplayFormat(DataFormatString = "99/99/9999")]
        public String DataInicio { get; set; }

        [DisplayFormat(DataFormatString = "99/99/9999")]
        public String DataFim { get; set; }

        public String Aluno { get; set; }

        public String Matricula { get; set; }
    }
}