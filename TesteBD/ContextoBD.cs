using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBD
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
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Universidade>()
                        .HasMany<Curso>(u => u.cursos)
                        .WithRequired(c => c.universidade)
                        .HasForeignKey(c => c.universidadeId);

           modelBuilder.Entity<Curso>()
                   .HasOptional(coor => coor.coordenador)
                   .WithRequired(cur => cur.curso);

            modelBuilder.Entity<Curso>()
                       .HasMany<Aluno>(c => c.alunos)
                       .WithRequired(a => a.curso)
                       .HasForeignKey(a => a.cursoId);

            modelBuilder.Entity<Curso>()
                      .HasMany<Professor>(c => c.professores)
                      .WithRequired(p => p.curso)
                      .HasForeignKey(p => p.cursoId);

            modelBuilder.Entity<Turma>()
                 .HasMany<Aluno>(t => t.alunos)
                 .WithMany(a => a.turmas)
                 .Map(cs =>
                 {
                     cs.MapLeftKey("turmaId");
                     cs.MapRightKey("alunoId");
                     cs.ToTable("TurmaAluno");
                 });

            modelBuilder.Entity<Aluno>()
                        .HasMany<Nota>(a => a.notas)
                        .WithRequired(n => n.aluno)
                        .HasForeignKey(n => n.alunoId);

            modelBuilder.Entity<Avaliacao>()
                        .HasMany<Nota>(a => a.notas)
                        .WithRequired(n => n.avaliacao)
                        .HasForeignKey(n => n.avaliacaoId);

            modelBuilder.Entity<Professor>()
                       .HasMany<Turma>(p => p.turmas)
                       .WithRequired(t => t.professor)
                       .HasForeignKey(t => t.professorId);
            
            /*modelBuilder.Entity<Endereco>()
            .HasKey(e => e.pessoaId);

            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<Pessoa>()
                        .HasOptional(p => p.endereco) // Mark StudentAddress is optional for Student
                        .WithRequired(e => e.pessoa); // Create inverse relationship*/
            
            modelBuilder.Entity<Aluno>()
                    .HasRequired(a => a.pessoa)
                    .WithOptional(p => p.aluno);

            modelBuilder.Entity<Coordenador>()
                    .HasRequired(c => c.pessoa)
                    .WithOptional(p => p.coordenador);

            modelBuilder.Entity<Professor>()
                    .HasRequired(p => p.pessoa)
                    .WithOptional(p => p.professor);

            base.OnModelCreating(modelBuilder);
        }
               
        public ContextoBD(): base("BDASW")
        {

        }
    }
}
