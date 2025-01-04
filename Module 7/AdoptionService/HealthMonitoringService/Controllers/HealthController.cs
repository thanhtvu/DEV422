using Microsoft.AspNetCore.Mvc;

using HealthMonitoringService.Model;
using Microsoft.AspNetCore.Components.Web;
using HealthMonitoringService.Data;
using Microsoft.EntityFrameworkCore;

namespace HealthMonitoringService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        private readonly HealthContext context;

        // constructor
        public HealthController(HealthContext context)
        {
            this.context = context;
        }

        [HttpGet("checkhealth")]
        public async Task<IActionResult> CheckHealth(int petId)
        {
            var status = await context.HealthStatuses.FirstOrDefaultAsync( h => h.PetId == petId);
            status.LastChecked = DateTime.Now;

            //Randomly chagne the health status
            Random rnd = new Random();
            if(rnd.Next(100) < 10) // 10 % chance of health issue
            {
                status.IsHealthy = false;
                status.AlertMessage = "Pet might need a check up";
            }
            else
            {
                status.IsHealthy = true;
                status.AlertMessage = "Pet is healthy!";
            }


            return Ok(status);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        { 
            return Ok(await context.HealthStatuses.ToListAsync()); 
        }
    }
}
