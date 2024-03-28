using Microsoft.EntityFrameworkCore;

namespace BackendNet.Models
{
    public class DBContext: DbContext
    {

        public DBContext(DbContextOptions<DBContext> options): base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventoCampus>()
                .HasKey(ec => new { ec.EventoId, ec.CampusId });

            modelBuilder.Entity<EventoCampus>()
                .HasOne(ec => ec.Evento)
                .WithMany(e => e.EventoCampus)
                .HasForeignKey(ec => ec.EventoId);

            modelBuilder.Entity<EventoCampus>()
                .HasOne(ec => ec.Campus)
                .WithMany()
                .HasForeignKey(ec => ec.CampusId);
        }

        public DbSet<Campus> Campus { get; set; }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Organizador> Organizador { get; set; }
        public DbSet<SubtipoEvento> SubtipoEvento { get; set; }
        public DbSet<TipoEvento> TipoEvento { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }
        public DbSet<Evento> Evento { get; set; }

    }
}
