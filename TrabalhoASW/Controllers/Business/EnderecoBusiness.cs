using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class EnderecoBusiness
    {
        EnderecoRepository repositorio;

        public EnderecoBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            repositorio = unidadeDeTrabalho.EnderecoRepository;
        }
        public Endereco criaEndereco(string logradouro, int numero, string apto, string bairro, string cidade, string estado, string cep)
        {
            Endereco endereco = new Endereco();
            endereco.logradouro = logradouro;
            endereco.numero = numero;
            endereco.complemento = apto;
            endereco.bairro = bairro;
            endereco.cidade = cidade;
            endereco.estado = estado;
            endereco.cep = cep;
            return endereco;
        }
    }
}