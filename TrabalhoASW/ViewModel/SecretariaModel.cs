using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoASW.ViewModel
{
    public class SecretariaModel
    {
        public String Curso { get; set; }

        public String Disciplina { get; set; }

        [DisplayFormat(DataFormatString = "99/99/9999")]
        public String DataInicio { get; set; }

        [DisplayFormat(DataFormatString = "99/99/9999")]
        public String DataFim { get; set; }

        [Required(ErrorMessage="Favor informar matrícula do aluno")]
        public String Aluno { get; set; }

    }
}