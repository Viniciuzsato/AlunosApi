using AlunosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunosApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Vinicius sato",
                    Email = "Vinicius.sato@outlook.com",
                    Idade = 29
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Natalia sato",
                    Email = "Natalia.sato@outlook.com",
                    Idade = 26
                }

            );

        }
    }
}
