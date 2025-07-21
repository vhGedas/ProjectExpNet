using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectExpNet.Data
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options) { }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Telefone>().ToTable("TELEFONES");
            modelBuilder.Entity<Cidade>().ToTable("CIDADES");
        }
    }

}