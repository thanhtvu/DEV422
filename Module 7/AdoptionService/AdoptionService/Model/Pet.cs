using System.ComponentModel.DataAnnotations;

namespace AdoptionService.Model
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Age {  get; set; }
        public string PersonalityType {  get; set; } =string.Empty;
        public string AdoptedBy { get; set; } = string.Empty;
        public bool IsAdopted {  get; set; }


    }
}
