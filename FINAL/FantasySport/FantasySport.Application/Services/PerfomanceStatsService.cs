using FantasySport.Application.Interfaces.Repositories;
using FantasySport.Application.Interfaces.Services;
using FantasySport.Core.Models;

namespace FantasySport.Application.Services
{
    public class PerfomanceStatsService(IPerfomanceStatsRepository repository) : IPermonaceStatsService
    {
        public async Task<Guid> CreateStat(PerformanceStat performanceStat) => await repository.Create(performanceStat);

        public async Task<List<PerformanceStat>> GetAll() => await repository.Read();
    }
}
