using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using prova_dev_API.Models;


namespace prova_dev_API.Data
{
    public class DataContent: DbContext {
        public DataContent(DbContextOptions<DataContent> options) : base (options) { }
        public DbSet<cadastro> nome { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){

            builder.Entity<cadastro>()
            .HasData(new List<cadastro>() {
                new cadastro(1,"nome","email", 123456, "huti","gsdjfn","jfvnsjk","jfjsn"),
                new cadastro(2,"nome","email", 123456, "huti","gsdjfn","jfvnsjk","jfjsn")
            });
        }
    }
}

