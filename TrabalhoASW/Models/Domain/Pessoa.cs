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
        public int Id { get; set; }
        [Required, MaxLength(60), MinLength(3)]
        public string nome { get; set; }
        [Required, MaxLength(12), MinLength(12)]
        public string cpf { get; set; }
        [Required, EmailAddress, MaxLength(100), MinLength(5)]
        public string email { get; set; }
        [Required, MaxLength(20), MinLength(9)]
        public string telefone { get; set; }
        [Required]
        public Endereco endereco { get; set; }
        public ICollection<Matricula> matriculas { get; set; }
    }
}