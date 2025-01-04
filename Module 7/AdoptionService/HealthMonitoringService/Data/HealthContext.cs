using HealthMonitoringService.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace HealthMonitoringService.Data
{
    public class HealthContext : DbContext
    {
        //constructor
        public HealthContext(DbContextOptions<HealthContext> options) :base(options)
        { 
            //empty
        }
        public DbSet<HealthStatus> HealthStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HealthStatus>().HasData(
                new HealthStatus
                {
                    Id = 1,
                    PetId = 1
                },
                new HealthStatus
                {
                    Id = 2,
                    PetId = 2
                },
                new HealthStatus
                {
                    Id = 3,
                    PetId = 3
                }
                );
        }

    }
}
