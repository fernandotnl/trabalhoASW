using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoASW.ViewModel
{
    public class AlunoModel
    {
        public Int32 Disciplina { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public String DataInicio { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public String DataFim { get; set; }
    }
}