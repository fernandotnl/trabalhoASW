using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business.ContextoBancoDados
{
    public class CriaBanco
    {
        ContextoBD context;

        UniversidadeBusiness universidadeBusiness;
        CursoBusiness cursoBusiness;
        EnderecoBusiness enderecoBusiness;
        PessoaBusiness pessoaBusiness;
        MatriculaBusiness matriculaBusiness;
        AlunoBusiness alunoBusiness;
        ProfessorBusiness professorBusiness;
        CoordenadorBusiness coordenadorBusiness;
        DisciplinaBusiness disciplinaBusiness;
        PeriodoBusiness periodoBusiness;
        AvaliacaoBusiness avaliacaoBusiness;
        NotaBusiness notaBusiness;
        TurmaBusiness turmaBusiness;

        public CriaBanco(UnidadeDeTrabalho unidadeDeTrabalho)
        {
            universidadeBusiness = new UniversidadeBusiness(unidadeDeTrabalho);
            cursoBusiness = new CursoBusiness(unidadeDeTrabalho);
            enderecoBusiness = new EnderecoBusiness(unidadeDeTrabalho);
            pessoaBusiness = new PessoaBusiness(unidadeDeTrabalho);
            matriculaBusiness = new MatriculaBusiness(unidadeDeTrabalho);
            alunoBusiness = new AlunoBusiness(unidadeDeTrabalho);
            professorBusiness = new ProfessorBusiness(unidadeDeTrabalho);
            coordenadorBusiness = new CoordenadorBusiness(unidadeDeTrabalho);
            disciplinaBusiness = new DisciplinaBusiness(unidadeDeTrabalho);
            periodoBusiness = new PeriodoBusiness(unidadeDeTrabalho);
            avaliacaoBusiness = new AvaliacaoBusiness(unidadeDeTrabalho);
            notaBusiness = new NotaBusiness(unidadeDeTrabalho);
            turmaBusiness = new TurmaBusiness(unidadeDeTrabalho);

            using (var contextVar = new ContextoBD())
            {
                //Universidades
                List<Universidade> universidades = new List<Universidade>();
                Universidade universidade = universidadeBusiness.criaUniversidade("Universidade1");
                universidades.Add(universidade);
                universidadeBusiness.persisteUniversidades(universidades);

                //Cursos
                List<Curso> cursos = new List<Curso>();
                Curso curso1 = cursoBusiness.criaCurso("Curso1", universidade);
                Curso curso2 = cursoBusiness.criaCurso("Curso2", universidade);
                cursos.Add(curso1);
                cursos.Add(curso2);
                cursoBusiness.persisteCursos(cursos);
                
                //Enderecos
                Endereco endereco1 = enderecoBusiness.criaEndereco("Rua 01", 1, "apto 01", "bairro1", "cidade1", "estado1", "11111-11");
                Endereco endereco2 = enderecoBusiness.criaEndereco("Rua 02", 2, "apto 02", "bairro2", "cidade2", "estado2", "22222-22");
                Endereco endereco3 = enderecoBusiness.criaEndereco("Rua 03", 3, "apto 03", "bairro3", "cidade3", "estado3", "33333-33");
                Endereco endereco4 = enderecoBusiness.criaEndereco("Rua 04", 4, "apto 04", "bairro4", "cidade4", "estado4", "44444-44");
                Endereco endereco5 = enderecoBusiness.criaEndereco("Rua 05", 5, "apto 05", "bairro5", "cidade5", "estado5", "55555-55");
                Endereco endereco6 = enderecoBusiness.criaEndereco("Rua 06", 6, "apto 06", "bairro6", "cidade6", "estado6", "66666-66");
               
                //Pessoas
                List<Pessoa> pessoas = new List<Pessoa>();
                Pessoa pessoa1 = pessoaBusiness.criaPessoa("Pessoa1", "111111111-11", "pessoa1@email.com.br", "1111-1111", endereco1);
                Pessoa pessoa2 = pessoaBusiness.criaPessoa("Pessoa2", "222222222-22", "pessoa2@email.com.br", "2222-2222", endereco2);
                Pessoa pessoa3 = pessoaBusiness.criaPessoa("Pessoa3", "333333333-33", "pessoa3@email.com.br", "3333-3333", endereco3);
                Pessoa pessoa4 = pessoaBusiness.criaPessoa("Pessoa4", "444444444-44", "pessoa4@email.com.br", "4444-4444", endereco4);
                Pessoa pessoa5 = pessoaBusiness.criaPessoa("Pessoa5", "555555555-55", "pessoa5@email.com.br", "5555-5555", endereco5);
                Pessoa pessoa6 = pessoaBusiness.criaPessoa("Pessoa6", "666666666-66", "pessoa6@email.com.br", "6666-6666", endereco6);
                pessoas.Add(pessoa1);
                pessoas.Add(pessoa2);
                pessoas.Add(pessoa3);
                pessoas.Add(pessoa4);
                pessoas.Add(pessoa5);
                pessoas.Add(pessoa6);
                pessoaBusiness.persistePessoas(pessoas);

                //Matriculas
                Matricula matricula1 = matriculaBusiness.criaMatricula("00001", TipoMatricula.ALUNO, pessoa1);
                Matricula matricula2 = matriculaBusiness.criaMatricula("00002", TipoMatricula.ALUNO, pessoa1);
                Matricula matricula3 = matriculaBusiness.criaMatricula("00003", TipoMatricula.PROFESSOR, pessoa1);
                Matricula matricula4 = matriculaBusiness.criaMatricula("00004", TipoMatricula.PROFESSOR, pessoa1);
                Matricula matricula5 = matriculaBusiness.criaMatricula("00005", TipoMatricula.COORDENADOR, pessoa1);
                Matricula matricula6 = matriculaBusiness.criaMatricula("00006", TipoMatricula.COORDENADOR, pessoa1);

                List<Matricula> matriculas = new List<Matricula>();
                matriculas.Add(matricula1);
                matriculas.Add(matricula2);
                matriculas.Add(matricula3);
                matriculas.Add(matricula4);
                matriculas.Add(matricula5);
                matriculas.Add(matricula6);
                matriculaBusiness.persisteMatriculas(matriculas);

                //Alunos
                List<Aluno> alunos = new List<Aluno>();
                Aluno aluno1 = alunoBusiness.criaAluno(curso1, pessoa1);
                Aluno aluno2 = alunoBusiness.criaAluno(curso1, pessoa2);
                alunos.Add(aluno1);
                alunos.Add(aluno2);
                alunoBusiness.persisteAlunos(alunos);

                //Professores
                List<Professor> professores = new List<Professor>();
                Professor professor1 = professorBusiness.criaProfessor(curso1, pessoa3);
                Professor professor2 = professorBusiness.criaProfessor(curso2, pessoa4);
                professores.Add(professor1);
                professores.Add(professor2);
                professorBusiness.persisteProfessores(professores);

                //Coordenadores
                List<Coordenador> coordenadores = new List<Coordenador>();
                Coordenador coordenador1 = coordenadorBusiness.criaCoordenador(curso1, pessoa5);
                Coordenador coordenador2 = coordenadorBusiness.criaCoordenador(curso2, pessoa6);
                coordenadores.Add(coordenador1);
                coordenadores.Add(coordenador2);
                coordenadorBusiness.persisteCoordenadores(coordenadores);
                
                //Associa Curso e Coordenador
                cursoBusiness.associaCursoCoordenador(curso1, coordenador1);
                cursoBusiness.associaCursoCoordenador(curso2, coordenador2);
               
                //Disciplinas
                List<Disciplina> disciplinas = new List<Disciplina>();
                Disciplina disciplina1 = disciplinaBusiness.criaDisciplina("disc01", "disciplina01");
                Disciplina disciplina2 = disciplinaBusiness.criaDisciplina("disc02", "disciplina02");
                disciplinas.Add(disciplina1);
                disciplinas.Add(disciplina2);
                disciplinaBusiness.persisteDisciplinas(disciplinas);

                //Periodos
                List<Periodo> periodos = new List<Periodo>();
                Periodo periodo1 = periodoBusiness.criaPeriodo(new DateTime(2015, 3, 1), new DateTime(2015, 7, 1), "01/2015");
                Periodo periodo2 = periodoBusiness.criaPeriodo(new DateTime(2015, 8, 1), new DateTime(2015, 12, 1), "02/2015");
                periodos.Add(periodo1);
                periodos.Add(periodo2);
                periodoBusiness.persistePeriodos(periodos);

                //Turmas
                List<Turma> turmas = new List<Turma>();
                Turma turma1 = turmaBusiness.criaTurma("turma1", disciplina1, professor1, periodo1, Turno.MATUTINO);
                turmas.Add(turma1);
                turmaBusiness.persisteTurmas(turmas);

                //Avaliacoes
                List<Avaliacao> avaliacoes = new List<Avaliacao>();
                Avaliacao avaliacao1 = avaliacaoBusiness.criaAvaliacao("prova1", turma1);
                Avaliacao avaliacao2 = avaliacaoBusiness.criaAvaliacao("prova2", turma1);
                avaliacoes.Add(avaliacao1);
                avaliacoes.Add(avaliacao2);
                avaliacaoBusiness.persisteAvaliacoes(avaliacoes);

                //Notas
                List<Nota> notas = new List<Nota>();
                Nota nota1 = notaBusiness.criaNota(aluno1, 10.0, avaliacao1);
                Nota nota2 = notaBusiness.criaNota(aluno2, 10.0, avaliacao1);
                Nota nota3 = notaBusiness.criaNota(aluno1, 10.0, avaliacao2);
                Nota nota4 = notaBusiness.criaNota(aluno2, 10.0, avaliacao2);
                notas.Add(nota1);
                notas.Add(nota2);
                notas.Add(nota3);
                notas.Add(nota4);
                notaBusiness.persisteNotas(notas);

                //Associa Alunos à turma
                turmaBusiness.associaTurmaAlunos(turma1, alunos);
                
                //Associa Avaliacoes à turma
                turmaBusiness.associaTurmaAvaliacoes(turma1, avaliacoes);
            }
        }
        
    }
}