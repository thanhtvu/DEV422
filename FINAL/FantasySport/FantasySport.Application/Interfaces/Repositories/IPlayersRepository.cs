using FantasySport.Core.Models;

namespace FantasySport.Application.Interfaces.Repositories
{
    public interface IPlayersRepository
    {
        Task<Guid> Create(Player player);
        Task<List<Player>> Read();
        Task<Guid> Update(Guid id, string name);
        Task<Guid> Update(Guid id, bool isActive);
        Task<Guid> Update(Guid id, Guid teamId);
        Task<Guid> Delete(Guid id);
        Task<List<Player>> GetTeamPlayers(Guid teamId);
    }
}
