using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TrabalhoASW.Models
{
    public class Endereco
    {
        /* Propriedades */
        [Required, MaxLength(9), MinLength(9) ]
        string cep { get; set; }
        [Required, MaxLength(100), MinLength(5)]
        string logradouro { get; set; }
        [Required]
        int numero { get; set; }
        [MaxLength(30), MinLength(0)]
        string complemento { get; set; }
        [Required, MaxLength(50), MinLength(5)]
        string bairro { get; set; }
        [Required, MaxLength(100), MinLength(5)]
        string cidade { get; set; }
        [Required, MaxLength(2), MinLength(2)]
        string estado { get; set; }
    }
}
