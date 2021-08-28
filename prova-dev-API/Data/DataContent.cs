using Microsoft.EntityFrameworkCore;
using prova_dev_API.Models;


namespace prova_dev_API.Data
{
    public class DataContent: DbContext
    {
        public DataContent(DbContextOptions<DataContent> options) : base (options) { }
        public DbSet<nome> nome { get; set; }
        public DbSet<email> email { get; set; }
        public DbSet<cpf> cpf { get; set; }
        public DbSet<renda> renda { get; set; }
        public DbSet<dtnasc> dtnasc { get; set; }
        public DbSet<celular> celular { get; set; }
        public DbSet<profissao> profissao { get; set; }

        protected override void OnModelCreating(ModelBuilder){
            Builder.Entity<>
        }
    }
}
