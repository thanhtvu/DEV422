namespace FantasySport.DataAccess.Entities
{
    public class PerformanceStatEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid PlayerGuid { get; set; }
        public PlayerEntity? Player { get; set; }
        public int ScoreDiff { get; set; } = 0;
        public DateTime RecordDate { get; set; } = DateTime.Now;
    }
}
