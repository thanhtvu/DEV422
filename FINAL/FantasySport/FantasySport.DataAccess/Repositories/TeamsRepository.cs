using FantasySport.Application.Interfaces.Repositories;
using FantasySport.Core.Models;
using FantasySport.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FantasySport.DataAccess.Repositories
{
    public class TeamsRepository(FantasySportDbContext dbContext) : ITeamsRepository
    {
        public async Task<Guid> Create(Team team)
        {
            var teamEntity = new TeamEntity()
            {
                Id = team.Id,
                Name = team.Name,
            };
            await dbContext.Teams.AddAsync(teamEntity);
            await dbContext.SaveChangesAsync();

            return teamEntity.Id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await dbContext.Teams.Where(team => team.Id == id).ExecuteDeleteAsync();
            await dbContext.SaveChangesAsync();
            return id;
        }

        public async Task<List<Team>> Read()
        {
            var teamEntities = await dbContext.Teams.AsNoTracking().ToListAsync();

            var teams = teamEntities.Select(team => Team.Create(team.Id, team.Name).Team)
                .ToList();

            return teams;
        }

        public async Task<Guid> Update(Guid id, string name)
        {
            await dbContext.Teams
            .Where(team => team.Id == id)
            .ExecuteUpdateAsync(s => s
            .SetProperty(p => p.Name, p => name));

            return id;
        }
    }
}
