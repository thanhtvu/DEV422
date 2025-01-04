using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace SecurityApi.Controllers
{

    // Define the route template for this controller 
    [Route("api/[controller]")]

    // Indicate that this is an API controller
    [ApiController]

    // This attribute requires a valid JWT token for all endpoints
    [Authorize]


    public class ProtectedDataController : Controller
    {
        private static readonly List<Object> protectedData = new List<Object>
        {
            new { Id=1, Name="Sensitive Document 1", Content="Confidential information" },
            new { Id=2, Name="Sensitive Document 2", Content="Private Data" },
            new { Id=1, Name="Sensitive Document 1", Content="Restricted Access Content" },

        };

        [HttpGet]
        public IActionResult GetProtectedData()
        {
            // This was set in the JWT token creation (ClaimTypes.Name)
            var username = User.Identity?.Name;


            // Return both username & protected data
            return Ok( new
            {
                Message = $"Protected Data retrieved for user: {username}",
                Data = protectedData
            });
        }

        [HttpGet("user-profile")]
        public IActionResult GetUserProfile()
        {
            var userProfile = new
            {
                Username = User.Identity?.Name,
                Email = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value,
                FirstName = User.Claims.FirstOrDefault(c => c.Type == "FirstName")?.Value,
                LastName = User.Claims.FirstOrDefault(c => c.Type == "Lastname")?.Value,
            };

            return Ok(userProfile);
        }


    }
}
