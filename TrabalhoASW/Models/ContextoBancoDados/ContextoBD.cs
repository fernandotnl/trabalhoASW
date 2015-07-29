using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoASW.Models;

namespace TrabalhoASW.Models
{
    class ContextoBD : DbContext
    {
        public DbSet<Aluno> alunos { get; set; }
        public DbSet<Avaliacao> avaliacoes { get; set; }
        public DbSet<Coordenador> coordenadores { get; set; }
        public DbSet<Curso> cursos { get; set; }
        public DbSet<Disciplina> disciplinas { get; set; }
        public DbSet<Matricula> matriculas { get; set; }
        public DbSet<Nota> notas { get; set; }
        public DbSet<Periodo> periodos { get; set; }
        public DbSet<Pessoa> pessoas { get; set; }
        public DbSet<Professor> professores { get; set; }
        public DbSet<Turma> turmas { get; set; }
        public DbSet<Universidade> universidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
