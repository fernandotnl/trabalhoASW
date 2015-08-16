using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrabalhoASW.Models;
using TrabalhoASW.Models.Repository;

namespace TrabalhoASW.Controllers.Business
{
    public class BancoDadosBusiness
    {
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

        public BancoDadosBusiness(UnidadeDeTrabalho unidadeDeTrabalho)
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

            criaInformacoesCurso();
        }

        private void criaInformacoesCurso()
        {
            //Universidades
            List<Universidade> universidades = new List<Universidade>();
            Universidade universidade = universidadeBusiness.criaUniversidade("Universidade1");
            universidades.Add(universidade);
            universidadeBusiness.persisteUniversidades(universidades);

            List<Periodo> periodos = new List<Periodo>();
            Periodo periodo1 = periodoBusiness.criaPeriodo(new DateTime(2015, 8, 1), new DateTime(2015, 12, 1), "02/2015");
            Periodo periodo2 = periodoBusiness.criaPeriodo(new DateTime(2016, 3, 1), new DateTime(2016, 7, 1), "01/2016");
            Periodo periodo3 = periodoBusiness.criaPeriodo(new DateTime(2016, 8, 1), new DateTime(2016, 12, 1), "02/2016");
            Periodo periodo4 = periodoBusiness.criaPeriodo(new DateTime(2017, 3, 1), new DateTime(2017, 7, 1), "01/2017");
            
            periodos.Add(periodo1);
            periodos.Add(periodo2);
            periodos.Add(periodo3);
            periodos.Add(periodo4);
            periodoBusiness.persistePeriodos(periodos);

            //Cursos
            List<Curso> cursos = new List<Curso>();
            Curso curso1 = cursoBusiness.criaCurso("Curso1", universidade);
            Curso curso2 = cursoBusiness.criaCurso("Curso2", universidade);
            //Curso curso3 = cursoBusiness.criaCurso("Curso3", universidade);
            cursos.Add(curso1);
            cursos.Add(curso2);
            //cursos.Add(curso3);
            cursoBusiness.persisteCursos(cursos);

            int qtdPessoas = criar(curso1, periodos, 0);
            qtdPessoas = criar(curso2, periodos, qtdPessoas);
            //qtdPessoas = criar(curso3, periodos, qtdPessoas);

        }

        private int criar(Curso curso, List<Periodo> periodos, int qtdPessoas)
        {
            List<Disciplina> disciplinas = new List<Disciplina>();
            Disciplina disciplina1 = disciplinaBusiness.criaDisciplina(curso.nome + "- disc01", curso.nome + "- disciplina01");
            Disciplina disciplina2 = disciplinaBusiness.criaDisciplina(curso.nome + "- disc02", curso.nome + "- disciplina02");
            Disciplina disciplina3 = disciplinaBusiness.criaDisciplina(curso.nome + "- disc03", curso.nome + "- disciplina03");
            Disciplina disciplina4 = disciplinaBusiness.criaDisciplina(curso.nome + "- disc04", curso.nome + "- disciplina04");
            Disciplina disciplina5 = disciplinaBusiness.criaDisciplina(curso.nome + "- disc05", curso.nome + "- disciplina05");
            Disciplina disciplina6 = disciplinaBusiness.criaDisciplina(curso.nome + "- disc06", curso.nome + "- disciplina06");
            Disciplina disciplina7 = disciplinaBusiness.criaDisciplina(curso.nome + "- disc07", curso.nome + "- disciplina07");
            Disciplina disciplina8 = disciplinaBusiness.criaDisciplina(curso.nome + "- disc08", curso.nome + "- disciplina08");
            Disciplina disciplina9 = disciplinaBusiness.criaDisciplina(curso.nome + "- disc09", curso.nome + "- disciplina09");
            Disciplina disciplina10 = disciplinaBusiness.criaDisciplina(curso.nome + "- disc10", curso.nome + "- disciplina10");
            disciplinas.Add(disciplina1);
            disciplinas.Add(disciplina2);
            disciplinas.Add(disciplina3);
            disciplinas.Add(disciplina4);
            disciplinas.Add(disciplina5);
            disciplinas.Add(disciplina6);
            disciplinas.Add(disciplina7);
            disciplinas.Add(disciplina8);
            disciplinas.Add(disciplina9);
            disciplinas.Add(disciplina10);
            disciplinaBusiness.persisteDisciplinas(disciplinas);

            List<Pessoa> pessoas = new List<Pessoa>();
            List<Matricula> matriculas = new List<Matricula>();
            List<Aluno> alunos = new List<Aluno>();
            List<Professor> professores = new List<Professor>();
            List<Coordenador> coordenadores = new List<Coordenador>();

            qtdPessoas++;
            Endereco enderecoCoordenador = enderecoBusiness.criaEndereco("Rua " + qtdPessoas, qtdPessoas, "apto " + qtdPessoas, "bairro" + qtdPessoas, "cidade" + qtdPessoas, "estado" + qtdPessoas, "11111-11");
            Pessoa pessoaCoordenador = pessoaBusiness.criaPessoa("Pessoa" + qtdPessoas, "111111111-11", "pessoa" + qtdPessoas + "@email.com.br", "1111-1111", enderecoCoordenador);
            Matricula matriculaCoordenador = matriculaBusiness.criaMatricula(qtdPessoas.ToString(), TipoMatricula.COORDENADOR, pessoaCoordenador);
            matriculas.Add(matriculaCoordenador);
            
            Coordenador coordenador = coordenadorBusiness.criaCoordenador(curso, pessoaCoordenador);
            coordenadores.Add(coordenador);
            coordenadorBusiness.persisteCoordenadores(coordenadores);
           
            for (int i = 1; i <= 63; i++) 
            {
                qtdPessoas++;
                
                Endereco endereco = enderecoBusiness.criaEndereco("Rua " + qtdPessoas, qtdPessoas, "apto " + qtdPessoas, "bairro" + qtdPessoas, "cidade" + qtdPessoas, "estado" + qtdPessoas, "11111-11");
                Pessoa pessoa = pessoaBusiness.criaPessoa("Pessoa" + qtdPessoas, "111111111-11", "pessoa" + qtdPessoas + "@email.com.br", "1111-1111", endereco);
                pessoas.Add(pessoa);
                if (i % 20 != 0) 
                {
                    Matricula matricula = matriculaBusiness.criaMatricula(qtdPessoas.ToString(), TipoMatricula.ALUNO, pessoa);
                    Aluno aluno = alunoBusiness.criaAluno(curso, pessoa);
                    matriculas.Add(matricula);
                    alunos.Add(aluno);
                }
                else
                {
                    Matricula matricula = matriculaBusiness.criaMatricula(qtdPessoas.ToString(), TipoMatricula.PROFESSOR, pessoa);
                    Professor professor = professorBusiness.criaProfessor(curso, pessoa);
                    professores.Add(professor);
                    matriculas.Add(matricula);
                }
            }

            pessoaBusiness.persistePessoas(pessoas);
            matriculaBusiness.persisteMatriculas(matriculas);
            alunoBusiness.persisteAlunos(alunos);
            professorBusiness.persisteProfessores(professores);
            cursoBusiness.associaCursoCoordenador(curso, coordenador);

            List<Turma> turmas = new List<Turma>();
            
            int indiceDisciplina = 0;
            int contTurma = 0;
            foreach(Periodo periodo in periodos)
            {
                foreach (Professor professor in professores)
                {
                    Disciplina disciplina = disciplinas.ElementAt(indiceDisciplina);
                    if (indiceDisciplina < disciplinas.Count()-1)
                    {
                        indiceDisciplina++;
                    }
                    else
                    {
                        indiceDisciplina = 0;
                    }
                    
                    Turma turma = turmaBusiness.criaTurma("turma"+contTurma, disciplina, professor, periodo, Turno.MATUTINO);
                    contTurma++;
                    turmas.Add(turma);
                }
            }
                
            turmaBusiness.persisteTurmas(turmas);
            
            List<Avaliacao> avaliacoes = new List<Avaliacao>();
            
            List<Nota> notas = new List<Nota>();
            Random randNum = new Random();
            Dictionary<Turma, List<Avaliacao>> mapAvaliacoesPorTurma = new Dictionary<Turma, List<Avaliacao>>();
            for (int i = 0; i < turmas.Count; i++)
            {
                List<Aluno> alunosTurma = new List<Aluno>();
                Turma turma = turmas.ElementAt(i);
                if (i % 3 == 0)
                {
                    alunosTurma.AddRange(alunos.GetRange(0, 20));
                }
                else if (i % 3 == 1)
                {
                    alunosTurma.AddRange(alunos.GetRange(19, 20));
                }
                else
                {
                    alunosTurma.AddRange(alunos.GetRange(39, 20));
                }
                turmaBusiness.associaTurmaAlunos(turma, alunosTurma);

                List<Avaliacao> avaliacoesTurma = new List<Avaliacao>();
                Avaliacao avaliacao1 = avaliacaoBusiness.criaAvaliacao("prova1", turma);
                Avaliacao avaliacao2 = avaliacaoBusiness.criaAvaliacao("prova2", turma);
                Avaliacao avaliacao3 = avaliacaoBusiness.criaAvaliacao("prova3", turma);
                avaliacoesTurma.Add(avaliacao1);
                avaliacoesTurma.Add(avaliacao2);
                avaliacoesTurma.Add(avaliacao3);

                avaliacoes.AddRange(avaliacoesTurma);
                mapAvaliacoesPorTurma.Add(turma, avaliacoesTurma);
                foreach (Avaliacao avaliacao in avaliacoesTurma)
                {
                    foreach (Aluno aluno in alunosTurma)
                    {
                        Double valor = randNum.Next(10);
                        Nota nota = notaBusiness.criaNota(aluno, valor, avaliacao);
                        notas.Add(nota);
                    }

                }
            }
            avaliacaoBusiness.persisteAvaliacoes(avaliacoes);
            notaBusiness.persisteNotas(notas);
            return qtdPessoas;
        }
    }
}