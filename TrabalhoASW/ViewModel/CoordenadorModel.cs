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

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public String DataInicio { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public String DataFim { get; set; }

        public Int32 Aluno { get; set; }

        public Int32 Matricula { get; set; }
    }
}