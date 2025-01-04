using FantasySport.Core.Models;

namespace FantasySport.Application.Interfaces.Services
{
    public interface IPlayersService
    {
        Task<Guid> CreatePlayer(Player player);
        Task<List<Player>> GetAll();
        Task<Guid> UpdatePlayerName(Guid id, string name);
        Task<Guid> UpdatePlayerStatus(Guid id, bool status);
        Task<Guid> UpdatePlayerTeam(Guid id, Guid teamId);
        Task<Guid> DeletePlayer(Guid id);
        Task<List<Player>> GetTeamPlayers(Guid id);
    }
}
