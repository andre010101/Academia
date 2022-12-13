using CrudCadastroDeAlunos.DataModels;
using Microsoft.EntityFrameworkCore;

 namespace CrudCadastroDeAlunos
{
    public class Contexto : DbContext
    {
        public DbSet<Aluno> alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> matriculas { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;initial Catalog=cadastroAlunos;User ID=AtosEntity1;password=AtosEntity1;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
        }

    }
}