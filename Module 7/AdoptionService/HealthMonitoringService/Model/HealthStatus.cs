using System.ComponentModel.DataAnnotations;

namespace HealthMonitoringService.Model
{
    public class HealthStatus
    {
        [Key]
        public int Id { get; set; }
        public int PetId { get; set; }
        public bool IsHealthy { get; set; } = true;
        public string AlertMessage { get; set; } = "Pet is healthy!";
        public DateTime LastChecked { get; set; } = DateTime.Now;
    }
}
