using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoASW.ViewModel
{
    public class AlunoModel
    {
        public String Disciplina { get; set; }

        [DisplayFormat(DataFormatString = "99/99/9999")]
        public String DataInicio { get; set; }

        [DisplayFormat(DataFormatString = "99/99/9999")]
        public String DataFim { get; set; }
    }
}