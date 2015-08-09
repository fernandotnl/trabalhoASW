using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class PessoaBusiness
    {
        PessoaRepository repositorio;
        
        public PessoaBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.PessoaRepository;
        }

        public Pessoa criaPessoa(string nome, string cpf, string email, string telefone, Endereco endereco)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = nome;
            pessoa1.cpf = cpf;
            pessoa1.email = email;
            pessoa1.telefone = telefone;
            pessoa1.endereco = endereco;
            return pessoa1;
        }

        public void persistePessoas(ICollection<Pessoa> pessoas)
        {
           foreach (Pessoa pessoa in pessoas)
            {
                repositorio.context.pessoas.Add(pessoa);
            }
           repositorio.salva();
        }

    }
}