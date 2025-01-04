using FantasySport.Core.Models;

namespace FantasySport.Application.Interfaces.Repositories
{
    public interface ITeamsRepository
    {
        Task<Guid> Create(Team team);
        Task<List<Team>> Read();
        Task<Guid> Update(Guid id, string name);
        Task<Guid> Delete(Guid id);
    }
}
