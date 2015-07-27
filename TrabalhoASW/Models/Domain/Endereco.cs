using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TrabalhoASW.Models
{
    [ComplexType]
    public class Endereco
    {
        /* Propriedades */
        [Required, MaxLength(9), MinLength(9) ]
        public string cep { get; set; }
        [Required, MaxLength(100), MinLength(5)]
        public string logradouro { get; set; }
        [Required]
        public int numero { get; set; }
        [MaxLength(30), MinLength(0)]
        public string complemento { get; set; }
        [Required, MaxLength(50), MinLength(5)]
        public string bairro { get; set; }
        [Required, MaxLength(100), MinLength(5)]
        public string cidade { get; set; }
        [Required, MaxLength(2), MinLength(2)]
        public string estado { get; set; }
    }
}
