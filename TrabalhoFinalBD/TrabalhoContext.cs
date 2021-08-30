using Microsoft.EntityFrameworkCore;
using ClassLibrary1;
using Npgsql;

namespace Trabalho_Final_BD
{
    public class TrabalhoContext: DbContext
    {
        public TrabalhoContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=bd final");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MusicaPlaylist>()
                .HasKey(c => new { c.MusicaId, c.PlaylistId });
            modelBuilder.Entity<ArtistasFavoritos>()
                .HasKey(c => new { c.ArtistaId, c.UsuarioId });
            modelBuilder.Entity<Producao>()
                .HasKey(c => new { c.ProdutorId, c.MusicaId });
            modelBuilder.Entity<MusicasFavoritas>()
                .HasKey(c => new { c.MusicaId, c.UsuarioId });
            modelBuilder.Entity<AlbunsFavoritos>()
                .HasKey(c => new { c.AlbumId, c.UsuarioId });
        }
            
        public DbSet<Album> Albuns { get; set; }
        public DbSet<AlbunsFavoritos> AlbunsFavoritos { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<ArtistasFavoritos> ArtistasFavoritos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Musica> Musicas { get; set; }
        public DbSet<MusicasFavoritas> MusicasFavoritas { get; set; }
        public DbSet<PlanoDeAssinatura> PlanoDeAssinaturas { get; set; }
        public DbSet<MusicaPlaylist> MusicaPlaylist { get; set; }
        public DbSet<Playlist> Playlists{ get; set; }
        public DbSet<Producao> Producoes { get; set; }
        public DbSet<Produtor> Produtores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
