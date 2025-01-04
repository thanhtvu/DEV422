using Azure.Core;
using FantasySport.Application.Interfaces.Services;
using FantasySport.Core.Contracts.Players;
using FantasySport.Core.Contracts.Teams;
using FantasySport.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace FantasySport.Score.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfomanceController : ControllerBase
    {
        private readonly IPermonaceStatsService service;
        private readonly HttpClient _httpClient;
        public PerfomanceController(IPermonaceStatsService service, IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            this.service = service;
            _httpClient = httpClientFactory.CreateClient();
            var apiKey = configuration.GetSection("ApiKey").Value;
            _httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
        }


        [HttpGet("RunCompetition")]
        public async Task<ActionResult> RunCompetition()
        {
            try
            {
                var playerServiceResult = await _httpClient.GetStringAsync($"https://fanplayerservice-terry.azurewebsites.net/api/Players/GetActiveTeamPlayers");
                var players = System.Text.Json.JsonSerializer.Deserialize<List<PlayersResponse>>(playerServiceResult);
                foreach (var player in players)
                {
                    var result = PerformanceStat.Create(Guid.NewGuid(), player.id, new Random().Next(1, 11), DateTime.Now).Stat;
                    await service.CreateStat(result);
                }
                return Ok("Competition is completed");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet("UpdateLeaderboardForPlayers")]
        public async Task<ActionResult> UpdateLeaderboardForPlayers()
        {
            try
            {
                var stats = await service.GetAll();
                var playersString = await _httpClient.GetStringAsync($"https://fanscoreservice-terry.azurewebsites.net/api/Players/GetActiveTeamPlayers");
                var players = System.Text.Json.JsonSerializer.Deserialize<List<PlayersResponse>>(playersString);

                var playerScores = stats.GroupBy(ps => ps.PlaayerId)
                    .Select(g => new
                    {
                        PlayerId = g.Key,
                        TotalScore = g.Sum(ps => ps.ScoreDiff)
                    })
                    .OrderByDescending(x => x.TotalScore)
                    .Take(10)
                    .ToList();

                var topPlayers = playerScores
                                    .Join(players, ps => ps.PlayerId, p => p.id, (ps, p) => new
                                    {
                                        p.name,
                                        ps.TotalScore
                                    }).ToList();

                return Ok(new { message = "Competition is completed" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [HttpGet("UpdateLeaderboardForTeams")]
        public async Task<ActionResult> UpdateLeaderboardForTeams()
        {
            try
            {
                var stats = await service.GetAll();
                var teamsString = await _httpClient.GetStringAsync($"https://fantasyteamservice.azurewebsites.net/api/Teams/GetAll");
                var playersString = await _httpClient.GetStringAsync($"https://fanplayerservice-terry.azurewebsites.net/api/Players/GetActiveTeamPlayers");
                var teams = System.Text.Json.JsonSerializer.Deserialize<List<TeamsResponse>>(teamsString);
                var players = System.Text.Json.JsonSerializer.Deserialize<List<PlayersResponse>>(playersString);

                var playerScores = stats.GroupBy(ps => ps.PlaayerId)
                    .Select(g => new
                    {
                        PlayerId = g.Key,
                        TotalScore = g.Sum(ps => ps.ScoreDiff)
                    })
                    .OrderByDescending(x => x.TotalScore)
                    .Take(10)
                    .ToList();

                var teamScores = players.Join(playerScores, p => p.id, ps => ps.PlayerId, (p, ps) => new
                {
                    p.teamId,
                    ps.TotalScore
                })
                               .Where(x => x.teamId.HasValue)
                               .GroupBy(x => x.teamId.Value)
                               .Select(g => new
                               {
                                   TeamId = g.Key,
                                   AverageScore = g.Average(x => x.TotalScore)
                               })
                               .OrderByDescending(x => x.AverageScore)
                               .Take(10)
                               .ToList();


                var topTeams = teamScores
                    .Join(teams, ts => ts.TeamId, t => t.id, (ts, t) => new
                    {
                        t.name,
                        ts.AverageScore
                    })
                    .ToList();

                return Ok(new { success = true, data = topTeams });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, error = ex.Message });
            }
        }
    }
}
