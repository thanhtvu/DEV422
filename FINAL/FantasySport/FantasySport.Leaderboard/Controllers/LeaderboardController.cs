using Microsoft.AspNetCore.Mvc;

namespace FantasySport.Leaderboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeaderboardController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public LeaderboardController(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClient = httpClientFactory.CreateClient();
            var apiKey = configuration.GetSection("ApiKey").Value;
            _httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
        }

        [HttpGet("Get")]
        public async Task<ActionResult<string?>> GetLeaderboard()
        {
            try
            {
                var json = await _httpClient.GetStringAsync("https://fanleaderboardservice-terry.azurewebsites.net/api/Perfomance/UpdateLeaderboardForTeams");
                return Ok(json);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
