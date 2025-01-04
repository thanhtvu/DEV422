using AdoptionService.Model;
using Microsoft.EntityFrameworkCore;

namespace AdoptionService.Data
{
    public class AdoptionContext : DbContext
    {
        //contructor
        public AdoptionContext(DbContextOptions<AdoptionContext> options) : base(options)
        {
            // empty
        }

        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>().HasData(
                new Pet
                {
                    PetId = 1,
                    Name = "Max",
                    Type = "Dog",
                    Age = 3,
                    PersonalityType = "Friendly",
                    IsAdopted = false
                },
                new Pet
                {
                PetId = 2,
                Name = "Garfield",
                Type = "Cat",
                Age = 2,
                PersonalityType = "Playful",
                IsAdopted = false
                },
                new Pet
                {
                PetId = 3,
                Name = "Whiteshoes",
                Type = "Dog",
                Age = 4,
                PersonalityType = "Protective",
                IsAdopted = false
                }


                );
        }

    }
}
