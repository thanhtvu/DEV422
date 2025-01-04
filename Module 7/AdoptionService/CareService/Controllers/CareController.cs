using CareService.Data;
using CareService.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CareService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareController : ControllerBase
    {
        private readonly CareContext context;

        //constructor
        public CareController(CareContext careContext)
        {
            context = careContext;
        }

        //fucntion to feed the pet
        [HttpPost("feed")]
        public async Task<IActionResult> Feed(int petId)
        {
            var care = await context.PetCares.FirstOrDefaultAsync(p => p.PetId == petId);
            care.LastFed = DateTime.Now;
            care.HungerLevel = Math.Max(0,care.HungerLevel - 30); //decresing hunger, minimum is 0
            care.HappinessLevel = Math.Min(100,care.HappinessLevel + 10);
            return Ok(care);
        }

        [HttpPost("play")]
        public async Task<IActionResult> Play(int petId)
        {
            var care = await context.PetCares.FirstOrDefaultAsync(p => p.PetId == petId);
            care.LastPlayed = DateTime.Now;
            care.HappinessLevel = Math.Min(100, care.HappinessLevel + 10);
            care.HungerLevel = Math.Min(100, care.HungerLevel + 10);
            return Ok(care);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await context.PetCares.ToListAsync());
        }

        [HttpGet("status")]
        public async Task<IActionResult> GetStatus(int petId) 
        {
            var care = await context.PetCares.FirstOrDefaultAsync(p => p.PetId == petId);
            if (care == null)
                return NotFound();
            
            return Ok(care);
        }
    
    }
}
