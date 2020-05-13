using Locadora.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Repository
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext(DbContextOptions<LocadoraContext> options) : base(options)
        { }
        public DbSet<Aluguel> Aluguel { get; set; }
        public DbSet<Ator> Ator { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<GeneroStreaming> GeneroStreaming { get; set; }
        public DbSet<Plano> Plano { get; set; }
        public DbSet<Streaming> Streaming { get; set; }
        public DbSet<StreamingAtor> StreamingAtor { get; set; }
        public DbSet<TipoStreaming> TipoStreaming { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GeneroStreaming>().HasKey(x => new { x.StreamingId, x.GeneroId });
            modelBuilder.Entity<StreamingAtor>().HasKey(x => new { x.StreamingId, x.AtorId });
        }

    }
}
