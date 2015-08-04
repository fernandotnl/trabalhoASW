using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoASW.Models
{
    public class Pessoa
    {

        public Pessoa()
        {
            this.matriculas = new List<Matricula>();
        }

        /* Propriedades */
        [Key, Required]
        public int pessoaId { get; set; }
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

        public virtual Professor professor { get; set; }

        public virtual Coordenador coordenador { get; set; }

        public virtual Aluno aluno { get; set; }
    }
}