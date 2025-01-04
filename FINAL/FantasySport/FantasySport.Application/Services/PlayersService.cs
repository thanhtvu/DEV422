using FantasySport.Application.Interfaces.Repositories;
using FantasySport.Application.Interfaces.Services;
using FantasySport.Core.Models;

namespace FantasySport.Application.Services
{
    public class PlayersService(IPlayersRepository repository) : IPlayersService
    {
        public async Task<Guid> CreatePlayer(Player player) => await repository.Create(player);

        public async Task<Guid> DeletePlayer(Guid id) => await repository.Delete(id);

        public async Task<List<Player>> GetAll() => await repository.Read();

        public async Task<Guid> UpdatePlayerName(Guid id, string name) => await repository.Update(id, name);

        public async Task<Guid> UpdatePlayerStatus(Guid id, bool status) => await repository.Update(id, status);

        public async Task<Guid> UpdatePlayerTeam(Guid id, Guid teamId) => await repository.Update(id, teamId);
        public async Task<List<Player>> GetTeamPlayers(Guid teamId) => await repository.GetTeamPlayers(teamId);
    }
}
