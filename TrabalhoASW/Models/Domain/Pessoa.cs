using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models
{
    public class Pessoa
    {
        /* Propriedades */
        [Key, Required]
        int id { get; set; }
        [Required, MaxLength(60), MinLength(3)]
        string nome { get; set; }
        [Required, MaxLength(12), MinLength(12)]
        string cpf { get; set; }
        [Required, EmailAddress, MaxLength(100), MinLength(5)]
        string email { get; set; }
        [Required, MaxLength(20), MinLength(9)]
        string telefone { get; set; }
        [Required]
        Endereco endereco { get; set; }
        ICollection<Matricula> matriculas { get; set; }
    }
}