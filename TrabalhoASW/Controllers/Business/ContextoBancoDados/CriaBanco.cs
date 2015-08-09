using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;

namespace TrabalhoASW.Controllers.Business.ContextoBancoDados
{
    public class CriaBanco
    {

        public CriaBanco()
        {
            using (var context = new ContextoBD())
            {
                Universidade uni = new Universidade();
                uni.nome = "Universidade1";
                context.universidades.Add(uni);

                //Cursos
                Curso curso1 = new Curso();
                curso1.nome = "Curso1";
                curso1.universidade = uni;
                context.cursos.Add(curso1);

                Curso curso2 = new Curso();
                curso2.nome = "Curso2";
                curso2.universidade = uni;
                context.cursos.Add(curso2);

                //Pessoa 1
                Endereco endereco1 = new Endereco();
                endereco1.logradouro = "Rua 01";
                endereco1.numero = 1;
                endereco1.complemento = "apto 01";
                endereco1.bairro = "bairro1";
                endereco1.cidade = "cidade1";
                endereco1.estado = "estado1";
                endereco1.cep = "11111-11";

                Pessoa pessoa1 = new Pessoa();
                pessoa1.nome = "Pessoa1";
                pessoa1.cpf = "111111111-11";
                pessoa1.email = "pessoa1@email.com.br";
                pessoa1.telefone = "1111-1111";
                pessoa1.endereco = endereco1;
                context.pessoas.Add(pessoa1);

                Matricula matricula1 = new Matricula();
                matricula1.codigo = "001";
                matricula1.tipoMatricula = TipoMatricula.ALUNO;
                matricula1.pessoa = pessoa1;
                context.matriculas.Add(matricula1);
                
                Aluno aluno1 = new Aluno();
                aluno1.curso = curso1;
                aluno1.pessoa = pessoa1;
                context.alunos.Add(aluno1);

                //Pessoa 2
                Endereco endereco2 = new Endereco();
                endereco2.logradouro = "Rua 02";
                endereco2.numero = 2;
                endereco2.complemento = "apto 02";
                endereco2.bairro = "bairro2";
                endereco2.cidade = "cidade2";
                endereco2.estado = "estado2";
                endereco2.cep = "22222-22";

                Pessoa pessoa2 = new Pessoa();
                pessoa2.nome = "Pessoa2";
                pessoa2.cpf = "222222222-22";
                pessoa2.email = "pessoa2@email.com.br";
                pessoa2.telefone = "2222-2222";
                pessoa2.endereco = endereco2;
                context.pessoas.Add(pessoa2);

                Matricula matricula2 = new Matricula();
                matricula2.codigo = "002";
                matricula2.tipoMatricula = TipoMatricula.ALUNO;
                matricula2.pessoa = pessoa2;
                context.matriculas.Add(matricula2);
                
                Aluno aluno2 = new Aluno();
                aluno2.curso = curso1;
                aluno2.pessoa = pessoa2;
                context.alunos.Add(aluno2);

                //Pessoa 3
                Endereco endereco3 = new Endereco();
                endereco3.logradouro = "Rua 03";
                endereco3.numero = 3;
                endereco3.complemento = "apto 03";
                endereco3.bairro = "bairro3";
                endereco3.cidade = "cidade3";
                endereco3.estado = "estado3";
                endereco3.cep = "33333-33";

                Pessoa pessoa3 = new Pessoa();
                pessoa3.nome = "Pessoa3";
                pessoa3.cpf = "333333333-33";
                pessoa3.email = "pessoa3@email.com.br";
                pessoa3.telefone = "3333-3333";
                pessoa3.endereco = endereco3;
                context.pessoas.Add(pessoa3);

                Matricula matricula3 = new Matricula();
                matricula3.codigo = "003";
                matricula3.tipoMatricula = TipoMatricula.PROFESSOR;
                matricula3.pessoa = pessoa3;
                context.matriculas.Add(matricula3);
                
                Professor professor1 = new Professor();
                professor1.curso = curso1;
                professor1.pessoa = pessoa3;
                context.professores.Add(professor1);

                //Pessoa 4
                Endereco endereco4 = new Endereco();
                endereco4.logradouro = "Rua 04";
                endereco4.numero = 4;
                endereco4.complemento = "apto 04";
                endereco4.bairro = "bairro4";
                endereco4.cidade = "cidade4";
                endereco4.estado = "estado4";
                endereco4.cep = "44444-44";

                Pessoa pessoa4 = new Pessoa();
                pessoa4.nome = "Pessoa4";
                pessoa4.cpf = "444444444-44";
                pessoa4.email = "pessoa4@email.com.br";
                pessoa4.telefone = "4444-4444";
                pessoa4.endereco = endereco4;
                context.pessoas.Add(pessoa4);

                Matricula matricula4 = new Matricula();
                matricula4.codigo = "004";
                matricula4.tipoMatricula = TipoMatricula.PROFESSOR;
                matricula4.pessoa = pessoa4;
                context.matriculas.Add(matricula4);
                
                Professor professor2 = new Professor();
                professor2.curso = curso2;
                professor2.pessoa = pessoa4;
                context.professores.Add(professor2);

                //Pessoa 5
                Endereco endereco5 = new Endereco();
                endereco5.logradouro = "Rua 05";
                endereco5.numero = 5;
                endereco5.complemento = "apto 05";
                endereco5.bairro = "bairro5";
                endereco5.cidade = "cidade5";
                endereco5.estado = "estado5";
                endereco5.cep = "55555-55";

                Pessoa pessoa5 = new Pessoa();
                pessoa5.nome = "Pessoa5";
                pessoa5.cpf = "555555555-55";
                pessoa5.email = "pessoa5@email.com.br";
                pessoa5.telefone = "5555-5555";
                pessoa5.endereco = endereco5;
                context.pessoas.Add(pessoa5);

                Matricula matricula5 = new Matricula();
                matricula5.codigo = "005";
                matricula5.tipoMatricula = TipoMatricula.COORDENADOR;
                matricula5.pessoa = pessoa5;
                context.matriculas.Add(matricula5);
                
                Coordenador coordenador1 = new Coordenador();
                coordenador1.curso = curso1;
                coordenador1.pessoa = pessoa5;
                context.coordenadores.Add(coordenador1);

                //Pessoa 6
                Endereco endereco6 = new Endereco();
                endereco6.logradouro = "Rua 06";
                endereco6.numero = 6;
                endereco6.complemento = "apto 06";
                endereco6.bairro = "bairro6";
                endereco6.cidade = "cidade6";
                endereco6.estado = "estado6";
                endereco6.cep = "66666-66";

                Pessoa pessoa6 = new Pessoa();
                pessoa6.nome = "Pessoa6";
                pessoa6.cpf = "666666666-66";
                pessoa6.email = "pessoa6@email.com.br";
                pessoa6.telefone = "6666-6666";
                pessoa6.endereco = endereco6;
                context.pessoas.Add(pessoa6);

                Matricula matricula6 = new Matricula();
                matricula6.codigo = "006";
                matricula6.tipoMatricula = TipoMatricula.COORDENADOR;
                matricula6.pessoa = pessoa6;
                context.matriculas.Add(matricula6);
                
                Coordenador coordenador2 = new Coordenador();
                coordenador2.curso = curso2;
                coordenador2.pessoa = pessoa6;
                context.coordenadores.Add(coordenador2);
                context.SaveChanges();

                curso1.coordenador = coordenador1;
                curso1.coordenadorId = coordenador1.coordenadorId;

                curso2.coordenador = coordenador2;
                curso2.coordenadorId = coordenador2.coordenadorId;
                context.cursos.Attach(curso1);
                context.cursos.Attach(curso2);

                context.coordenadores.Attach(coordenador1);
                context.coordenadores.Attach(coordenador2);

                coordenador1.curso = curso1;
                coordenador1.cursoId = curso1.cursoId;

                coordenador2.curso = curso2;
                coordenador2.cursoId = curso2.cursoId;

                context.Entry(curso1).State = EntityState.Modified;
                context.Entry(curso2).State = EntityState.Modified;

                context.Entry(coordenador1).State = EntityState.Modified;
                context.Entry(coordenador2).State = EntityState.Modified;

                Disciplina disciplina1 = new Disciplina();
                disciplina1.codigo = "disc01";
                disciplina1.nome = "disciplina01";
                context.disciplinas.Add(disciplina1);

                Disciplina disciplina2 = new Disciplina();
                disciplina2.codigo = "disc02";
                disciplina2.nome = "disciplina02";
                context.disciplinas.Add(disciplina2);

                Periodo periodo1 = new Periodo();
                periodo1.dataInicio = new DateTime(2015, 3, 1);
                periodo1.dataFim = new DateTime(2015, 7, 1);
                periodo1.nome = "01/2015";
                context.periodos.Add(periodo1);

                Periodo periodo2 = new Periodo();
                periodo2.dataInicio = new DateTime(2015, 8, 1);
                periodo2.dataFim = new DateTime(2015, 12, 1);
                periodo2.nome = "02/2015";
                context.periodos.Add(periodo2);

                Avaliacao avaliacao1 = new Avaliacao();
                avaliacao1.nome = "prova1";
                context.avaliacoes.Add(avaliacao1);

                Avaliacao avaliacao2 = new Avaliacao();
                avaliacao2.nome = "prova2";
                context.avaliacoes.Add(avaliacao2);

                Nota nota1 = new Nota();
                nota1.aluno = aluno1;
                nota1.valor = 10;
                nota1.avaliacao = avaliacao1;
                context.notas.Add(nota1);

                Nota nota2 = new Nota();
                nota2.aluno = aluno2;
                nota2.valor = 10;
                nota2.avaliacao = avaliacao1;
                context.notas.Add(nota2);

                Nota nota3 = new Nota();
                nota3.aluno = aluno1;
                nota3.avaliacao = avaliacao2;
                nota3.valor = 10;
                context.notas.Add(nota3);

                Nota nota4 = new Nota();
                nota4.avaliacao = avaliacao2;
                nota4.aluno = aluno2;
                nota4.valor = 10;
                context.notas.Add(nota4);

                avaliacao1.notas.Add(nota1);
                avaliacao1.notas.Add(nota2);
                avaliacao2.notas.Add(nota3);
                avaliacao2.notas.Add(nota4);

                Turma turma1 = new Turma();
                turma1.codigo = "turma1";
                turma1.disciplina = disciplina1;
                turma1.periodo = periodo1;
                turma1.turno = Turno.MATUTINO;
                turma1.alunos.Add(aluno1);
                turma1.alunos.Add(aluno2);
                turma1.professor = professor1;
                turma1.avaliacoes.Add(avaliacao1);
                turma1.avaliacoes.Add(avaliacao2);
                
                context.turmas.Add(turma1);
                
                context.SaveChanges();
                Console.WriteLine("");
            }
        }
    }
}