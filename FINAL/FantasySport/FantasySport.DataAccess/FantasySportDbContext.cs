using FantasySport.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FantasySport.DataAccess
{
    public class FantasySportDbContext : DbContext
    {
        private readonly DbContextOptions<FantasySportDbContext> _options;
        public DbSet<TeamEntity> Teams { get; set; } = null!;
        public DbSet<PlayerEntity> Players { get; set; } = null!;
        public DbSet<PerformanceStatEntity> Perfomance { get; set; } = null!;

        public FantasySportDbContext(DbContextOptions<FantasySportDbContext> options) : base(options)
        {
            _options = options;
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PlayerEntity>()
                .HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(p => p.TeamId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<PerformanceStatEntity>()
                .HasOne(p => p.Player)
                .WithMany(t => t.PerformanceStats)
                .HasForeignKey(p => p.PlayerGuid)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
