using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoASW.ViewModel
{
    public class SecretariaModel
    {
        public Int32 Curso { get; set; }

        public Int32 Disciplina { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public String DataInicio { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public String DataFim { get; set; }

        [Required(ErrorMessage="Favor informar matrícula do aluno")]
        public Int32 Aluno { get; set; }

    }
}