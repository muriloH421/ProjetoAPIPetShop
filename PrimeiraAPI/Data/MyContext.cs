using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Data
{
    public class MyContext : IdentityDbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Teste> Testes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Teste>().ToTable("Teste");
        }
    }
}
