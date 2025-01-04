namespace FantasySport.Core.Models
{
    public class PerformanceStat
    {
        public Guid Id { get; }
        public Guid PlaayerId { get; }
        public int ScoreDiff { get; }
        public DateTime RecordDate { get; }

        private PerformanceStat(Guid id, Guid playerId, int scoreDiff, DateTime recordDate)
        {
            Id = id;
            PlaayerId = playerId;
            ScoreDiff = scoreDiff;
            RecordDate = recordDate;
        }
        public static (PerformanceStat Stat, string Error) Create(Guid id, Guid playerId, int scoreDiff, DateTime recordDate)
        {
            var error = string.Empty;
            var stat = new PerformanceStat(id, playerId, scoreDiff, recordDate);
            return (stat, error);
        }
    }
}
