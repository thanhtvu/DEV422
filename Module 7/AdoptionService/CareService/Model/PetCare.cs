using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CareService.Model
{
    public class PetCare
    {
        //fields
        [Key]
        public int Id { get; set; }
        public int PetId { get; set; }
        public DateTime LastFed { get; set; } = DateTime.Now;
        public DateTime LastPlayed { get; set; } = DateTime.Now;

        public int HappinessLevel { get; set; } = 50; // 0-100
        public int HungerLevel { get; set; } = 50; // 0-100 0 = not hungry, 100 = very hungry
    }
}