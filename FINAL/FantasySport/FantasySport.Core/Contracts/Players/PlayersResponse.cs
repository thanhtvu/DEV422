namespace FantasySport.Core.Contracts.Players
{
    public record PlayersResponse(Guid id, string name, bool status, Guid? teamId);
}
