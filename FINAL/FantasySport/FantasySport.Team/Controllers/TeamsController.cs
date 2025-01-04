using FantasySport.Application.Interfaces.Services;
using FantasySport.Core.Contracts.Players;
using FantasySport.Core.Contracts.Teams;
using Microsoft.AspNetCore.Mvc;

namespace FantasySport.Team.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamsService service;
        private readonly HttpClient _httpClient;
        public TeamsController(ITeamsService service, IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            this.service = service;
            _httpClient = httpClientFactory.CreateClient();
            var apiKey = configuration.GetSection("ApiKey").Value;
            _httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<List<TeamsResponse>>> GetTeams()
        {
            var teams = await service.GetAll();
            var response = teams.Select(f =>
                new TeamsResponse(f.Id, f.Name));
            return Ok(response);
        }

        [HttpPost("AddNew")]
        public async Task<ActionResult<Guid>> CreateTeam([FromBody] TeamsDataRequest request)
        {
            var result = Core.Models.Team.Create(Guid.NewGuid(), request.name);

            if (!string.IsNullOrEmpty(result.Error))
                return BadRequest(result.Error);

            await service.CreateTeam(result.Team);
            return Ok($"'{result.Team.Name}' added. ID is '{result.Team.Id}'");
        }

        [HttpPut("ChangeName/{id:guid}")]
        public async Task<ActionResult<Guid>> UpdateTeamName(Guid id, [FromBody] TeamsDataRequest request)
        {
            var teamId = await service.UpdateTeamName(id, request.name);
            return Ok(teamId);
        }
        [HttpDelete("Delete/{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteCategory(Guid id)
        {
            return Ok(await service.DeleteTeam(id));
        }

        [HttpGet("GetPlayers/{teamId:guid}")]
        public async Task<ActionResult<List<PlayersResponse>>> GetPlayers(Guid teamId)
        {
            try
            {
                var players = await _httpClient.GetStringAsync($"https://fanplayerservice-terry.azurewebsites.net/api/Players/{teamId}");
                return Ok(players);

            }
            catch (Exception)
            {
                return BadRequest("Players service is unavailable");
            }

        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet("Team/{teamId:guid}/Updated")]
        public IActionResult TeamUpdated(Guid teamId)
        {
            return Ok($"A new player added in the {teamId} team");
        }
    }
}
