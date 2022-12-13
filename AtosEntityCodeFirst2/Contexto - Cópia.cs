using AtosEntityCodeFirst2;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using AtosEntityCodeFirst2.DataModels;

public class Contexto : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Email> Email { get; set; }

    public Contexto()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer("Data Source=localhost; " + "initial Catalog=AtosEntity1;User ID=AtosEntity1; " + "password=AtosEntity1;language=Portuguese;Trusted_Connection=True;" + "TrustServerCertificate=True;");



    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>()
            .HasOne(e => e.pessoa)
            .WithMany(e => e.Emails)
            .OnDelete(DeleteBehavior.ClientCascade);
    }
}
