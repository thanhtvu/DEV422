namespace FantasySport.DataAccess.Entities
{
    public class TeamEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public ICollection<PlayerEntity> Players { get; set; } = new List<PlayerEntity>();
    }
}
