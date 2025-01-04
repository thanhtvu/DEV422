using FantasySport.Application.Interfaces.Repositories;
using FantasySport.Core.Models;
using FantasySport.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FantasySport.DataAccess.Repositories
{
    public class PerfomanceStatsRepository(FantasySportDbContext dbContext) : IPerfomanceStatsRepository
    {
        public async Task<Guid> Create(PerformanceStat performanceStat)
        {
            var performanceStatEntity = new PerformanceStatEntity()
            {
                Id = performanceStat.Id,
                PlayerGuid = performanceStat.PlaayerId,
                RecordDate = performanceStat.RecordDate,
                ScoreDiff = performanceStat.ScoreDiff
            };
            await dbContext.Perfomance.AddAsync(performanceStatEntity);
            await dbContext.SaveChangesAsync();

            return performanceStatEntity.Id;
        }

        public async Task<List<PerformanceStat>> Read()
        {
            var performanceStatEntities = await dbContext.Perfomance.AsNoTracking().ToListAsync();

            var perfomance = performanceStatEntities.Select(perfomance => PerformanceStat.Create(perfomance.Id, perfomance.PlayerGuid, perfomance.ScoreDiff, perfomance.RecordDate).Stat)
                .ToList();

            return perfomance;
        }
    }
}
