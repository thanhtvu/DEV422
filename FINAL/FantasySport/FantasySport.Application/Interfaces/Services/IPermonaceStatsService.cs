using FantasySport.Core.Models;

namespace FantasySport.Application.Interfaces.Services
{
    public interface IPermonaceStatsService
    {
        Task<Guid> CreateStat(PerformanceStat performanceStat);
        Task<List<PerformanceStat>> GetAll();
    }
}
