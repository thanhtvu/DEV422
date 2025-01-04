using FantasySport.Application.Interfaces.Repositories;
using FantasySport.Application.Interfaces.Services;
using FantasySport.Core.Models;

namespace FantasySport.Application.Services
{
    public class TeamsService(ITeamsRepository repository) : ITeamsService
    {
        public async Task<Guid> CreateTeam(Team team) => await repository.Create(team);

        public async Task<Guid> DeleteTeam(Guid id) => await repository.Delete(id);

        public async Task<List<Team>> GetAll() => await repository.Read();

        public async Task<Guid> UpdateTeamName(Guid id, string name) => await repository.Update(id, name);
    }
}
