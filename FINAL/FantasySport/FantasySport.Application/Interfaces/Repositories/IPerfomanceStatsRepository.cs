using FantasySport.Core.Models;

namespace FantasySport.Application.Interfaces.Repositories
{
    public interface IPerfomanceStatsRepository
    {
        Task<Guid> Create(PerformanceStat performanceStat);
        Task<List<PerformanceStat>> Read();
    }
}
