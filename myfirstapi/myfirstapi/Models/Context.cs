using Microsoft.EntityFrameworkCore;

namespace myfirstapi.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Rol> Rols { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Seans> Seanss { get; set; }
        public DbSet<Tur> Turs { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Bilet> Bilets { get; set; }
        public DbSet<Yonetmen> Yonetmens { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>()
                        .HasKey(r => r.RolId);
            modelBuilder.Entity<Rol>()
                        .Property(r => r.RolId);

            modelBuilder.Entity<Kullanici>()
                        .HasKey(k => k.KullaniciId);
            modelBuilder.Entity<Kullanici>()
                        .Property(k => k.KullaniciId);

            modelBuilder.Entity<Tur>()
                        .HasKey(k => k.TurId);
            modelBuilder.Entity<Tur>()
                        .Property(k => k.TurId);

            modelBuilder.Entity<Yonetmen>()
                        .HasKey(k => k.YonetmenId);
            modelBuilder.Entity<Yonetmen>()
                        .Property(k => k.YonetmenId);

            modelBuilder.Entity<Film>()
                        .HasKey(k => k.FilmId);
            modelBuilder.Entity<Film>()
                        .Property(k => k.FilmId);

            modelBuilder.Entity<Seans>()
                        .HasKey(k => k.SeansId);
            modelBuilder.Entity<Seans>()
                        .Property(k => k.SeansId);

            modelBuilder.Entity<Bilet>()
                        .HasKey(k => k.BiletId);
            modelBuilder.Entity<Bilet>()
                        .Property(k => k.BiletId);
        }
    }
}