namespace FantasySport.DataAccess.Entities
{
    public class PlayerEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public Guid? TeamId { get; set; }
        public TeamEntity? Team { get; set; }
        public ICollection<PerformanceStatEntity> PerformanceStats { get; set; } = new List<PerformanceStatEntity>();

    }
}
