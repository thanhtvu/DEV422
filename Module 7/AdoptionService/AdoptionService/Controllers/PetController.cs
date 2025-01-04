using AdoptionService.Data;
using AdoptionService.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdoptionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly AdoptionContext context;

        public PetController(AdoptionContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> Get()
        {
            return await context.Pets.ToListAsync();
        }

        // get function to retrieve the pets with id provided
        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> Get(int id)
        {
            var pet = await context.Pets.FindAsync(id);
            //validation to see if the pet exist
            if(pet == null)
            {
                return NotFound();
            }
            return pet;
        }

        [HttpPost("adopt")]
        public async Task<IActionResult> Adopt(int petID, string adopterName)
        {
            var pet = await context.Pets.FindAsync(petID);
            //validation to see if the pet exist
            if (pet == null)
            {
                return NotFound();
            }
            if (pet.IsAdopted)
            {
                return BadRequest("Pet is already adopted");
            }

            pet.IsAdopted = true;
            pet.AdoptedBy = adopterName;
            await context.SaveChangesAsync();
            return Ok(pet);
        }
    }
}
