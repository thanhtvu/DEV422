using FantasySport.Core.Models;

namespace FantasySport.Application.Interfaces.Services
{
    public interface ITeamsService
    {
        Task<Guid> CreateTeam(Team team);
        Task<List<Team>> GetAll();
        Task<Guid> UpdateTeamName(Guid id, string name);
        Task<Guid> DeleteTeam(Guid id);
    }
}
