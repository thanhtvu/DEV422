using CareService.Model;
using Microsoft.EntityFrameworkCore;

namespace CareService.Data
{
    public class CareContext : DbContext
    {
        //constructor
        public CareContext(DbContextOptions<CareContext> options) : base(options)
        { 
        //empty
        }

        public DbSet<PetCare> PetCares {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PetCare>().HasData(
                new PetCare
                {
                    Id = 1,
                    PetId = 1 

                },
                new PetCare
                {
                    Id = 2,
                    PetId = 2

                },
                new PetCare
                {
                    Id = 3,
                    PetId = 3

                }


                );
        }

    }
}
