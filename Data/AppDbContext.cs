using AtividadeFilmes.Models;
using Microsoft.EntityFrameworkCore;

namespace AtividadeFilmes.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Diretor> Diretores => Set<Diretor>();
        public DbSet<Filme> Filmes => Set<Filme>();
        public DbSet<Genero> Generos => Set<Genero>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Diretor>()
                .HasMany(d => d.Filmes)
                .WithOne(f => f.Diretor)
                .HasForeignKey(f => f.DiretorId);

            modelBuilder.Entity<Filme>()
                .HasMany(f => f.Generos)
                .WithMany(g => g.Filmes);
        }
    }
}