using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoASW.Models;

namespace TrabalhoASW.Models
{
    public class ContextoBD : DbContext
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

            modelBuilder.Entity<Curso>()
                        .HasRequired<Universidade>(c => c.universidade)
                        .WithMany(u => u.cursos).HasForeignKey(c => c.universidadeId);
            
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
                        .HasForeignKey(n => n.alunoId).WillCascadeOnDelete(false);

            modelBuilder.Entity<Avaliacao>()
                        .HasMany<Nota>(a => a.notas)
                        .WithRequired(n => n.avaliacao)
                        .HasForeignKey(n => n.avaliacaoId).WillCascadeOnDelete(false);

            modelBuilder.Entity<Professor>()
                       .HasMany<Turma>(p => p.turmas)
                       .WithRequired(t => t.professor)
                       .HasForeignKey(t => t.professorId);

            modelBuilder.Entity<Pessoa>()
                    .HasOptional(p => p.aluno).WithOptionalPrincipal(a => a.pessoa)
                    .WillCascadeOnDelete(true);

            modelBuilder.Entity<Pessoa>()
                   .HasOptional(p => p.coordenador).WithOptionalPrincipal(a => a.pessoa)
                   .WillCascadeOnDelete(true);

            modelBuilder.Entity<Pessoa>()
                   .HasOptional(p => p.professor).WithOptionalPrincipal(a => a.pessoa)
                   .WillCascadeOnDelete(true);

            modelBuilder.Entity<Curso>()
                   .HasOptional(cur => cur.coordenador)
                   .WithRequired(coor => coor.curso);

            modelBuilder.Entity<Coordenador>()
                   .HasRequired(coor => coor.curso)
                   .WithOptional(cur => cur.coordenador);

            /*modelBuilder.Entity<Matricula>()
                  .HasRequired(m => m.pessoa)
                  .WithMany(p => p.matriculas).WillCascadeOnDelete(true);
            */

            modelBuilder.Entity<Pessoa>()
                        .HasMany<Matricula>(p => p.matriculas)
                        .WithRequired(m => m.pessoa)
                        .HasForeignKey(m => m.pessoaId);//.WillCascadeOnDelete(true);
           
            modelBuilder.Entity<Turma>()
                        .HasMany<Avaliacao>(t => t.avaliacoes)
                        .WithRequired(a => a.turma)
                        .HasForeignKey(a => a.turmaId).WillCascadeOnDelete(false);
            base.OnModelCreating(modelBuilder);
        }

        public ContextoBD()
        {
            Database.SetInitializer<ContextoBD>(new CreateDatabaseIfNotExists<ContextoBD>());

            //Database.SetInitializer<ContextoBD>(new DropCreateDatabaseIfModelChanges<ContextoBD>());
            //Database.SetInitializer<ContextoBD>(new DropCreateDatabaseAlways<ContextoBD>());
        }
    }
}
