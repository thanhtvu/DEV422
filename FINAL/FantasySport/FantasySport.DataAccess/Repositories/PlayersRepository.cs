using FantasySport.Application.Interfaces.Repositories;
using FantasySport.Core.Models;
using FantasySport.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FantasySport.DataAccess.Repositories
{
    public class PlayersRepository(FantasySportDbContext dbContext) : IPlayersRepository
    {
        public async Task<Guid> Create(Player player)
        {
            var playerEntity = new PlayerEntity()
            {
                Id = player.Id,
                Name = player.Name,
                IsActive= player.IsActive,
                TeamId = player.TeamId
            };
            await dbContext.Players.AddAsync(playerEntity);
            await dbContext.SaveChangesAsync();

            return playerEntity.Id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await dbContext.Players.Where(player => player.Id == id).ExecuteDeleteAsync();
            await dbContext.SaveChangesAsync();
            return id;
        }

        public async Task<List<Player>> Read()
        {
            var playerEntities = await dbContext.Players.AsNoTracking().ToListAsync();

            var players = playerEntities.Select(player => Player.Create(player.Id, player.Name, player.IsActive, player.TeamId).Player)
                .ToList();

            return players;
        }

        public async Task<Guid> Update(Guid id, string name)
        {
            await dbContext.Players
           .Where(player => player.Id == id)
           .ExecuteUpdateAsync(s => s
           .SetProperty(p => p.Name, p => name));

            return id;
        }

        public async Task<Guid> Update(Guid id, bool isActive)
        {
            await dbContext.Players
          .Where(player => player.Id == id)
          .ExecuteUpdateAsync(s => s
          .SetProperty(p => p.IsActive, p => isActive));

            return id;
        }

        public async Task<Guid> Update(Guid id, Guid teamId)
        {
            await dbContext.Players
          .Where(player => player.Id == id)
          .ExecuteUpdateAsync(s => s
          .SetProperty(p => p.TeamId, p => teamId));

            return id;
        }


        public async Task<List<Player>> GetTeamPlayers(Guid teamId)
        {
            var playerEntities = await dbContext.Players
                .Where(player => player.TeamId == teamId)
                .AsNoTracking()
                .ToListAsync();

            var players = playerEntities
                .Select(player => Player.Create(player.Id, player.Name, player.IsActive, player.TeamId).Player)
                .ToList();

            return players;
        }
    }
}
