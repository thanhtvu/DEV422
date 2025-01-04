using FantasySport.Application.Interfaces.Services;
using FantasySport.Core.Contracts.Players;
using Microsoft.AspNetCore.Mvc;

namespace FantasySport.Player.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayersService service;
        private readonly HttpClient _httpClient;
        public PlayersController(IPlayersService service, IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            this.service = service;
            _httpClient = httpClientFactory.CreateClient();
            var apiKey = configuration.GetSection("ApiKey").Value;
            _httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<List<PlayersResponse>>> GetPlayers()
        {
            var players = await service.GetAll();
            var response = players.Select(player =>
                new PlayersResponse(player.Id, player.Name, player.IsActive, player.TeamId));
            return Ok(response);
        }

        [HttpPost("AddNew")]
        public async Task<ActionResult<Guid>> CreatePlayer([FromBody] PlayersNameRequest request)
        {
            var result = Core.Models.Player.Create(Guid.NewGuid(), request.name, true, null);

            if (!string.IsNullOrEmpty(result.Error))
                return BadRequest(result.Error);

            await service.CreatePlayer(result.Player);
            return Ok($"'{result.Player.Name}' added. ID is '{result.Player.Id}'");
        }

        [HttpPut("ChangeName/{id:guid}")]
        public async Task<ActionResult<Guid>> UpdatePlayerName(Guid id, [FromBody] PlayersNameRequest request)
        {
            var teamId = await service.UpdatePlayerName(id, request.name);
            return Ok(teamId);
        }

        [HttpPut("ChangeStatus/{id:guid}")]
        public async Task<ActionResult<Guid>> UpdatePlayerStatus(Guid id, [FromBody] PlayersStatusRequest request)
        {
            var teamId = await service.UpdatePlayerStatus(id, request.status);
            return Ok(teamId);
        }

        [HttpPut("Add/{id:guid}/ToTeam")]
        public async Task<ActionResult<Guid>> UpdatePlayerTeam(Guid id, [FromBody] PlayersTeamRequest request)
        {
            try
            {
                var teamId = await service.UpdatePlayerTeam(id, request.teamId);
                var teamServiceResponse = await _httpClient.GetStringAsync($"https://fantasyteamservice.azurewebsites.net/api/Teams/Team/{request.teamId}/Updated");
                return Ok(teamServiceResponse);
            }
            catch (Exception ex)
            {
                return BadRequest("Player added to the team. Failed to notify the team service");
            }

        }

        [HttpDelete("Delete/{id:guid}")]
        public async Task<ActionResult<Guid>> DeletePlayer(Guid id)
        {
            return Ok(await service.DeletePlayer(id));
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet("{teamId:guid}")]
        public async Task<ActionResult<List<PlayersResponse>>> GetPlayers(Guid teamId)
        {
            var players = await service.GetTeamPlayers(teamId);
            var response = players.Select(player =>
                new PlayersResponse(player.Id, player.Name, player.IsActive, player.TeamId));
            return Ok(response);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet("GetActiveTeamPlayers")]
        public async Task<ActionResult<List<PlayersResponse>>> GetActiveTeamPlayers()
        {
            var players = await service.GetAll();
            var response = players.Where(player => player.IsActive && player.TeamId != null).Select(player =>
                new PlayersResponse(player.Id, player.Name, player.IsActive, player.TeamId));
            return Ok(response);
        }
    }
}
