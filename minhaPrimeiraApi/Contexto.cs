
using minhaPrimeiraApi.DataModels;
using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }


    public Contexto()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;initial Catalog=TesteApi;User ID=TesteApi;password=TesteApi;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");
        optionsBuilder.UseLazyLoadingProxies();
    }

    
}