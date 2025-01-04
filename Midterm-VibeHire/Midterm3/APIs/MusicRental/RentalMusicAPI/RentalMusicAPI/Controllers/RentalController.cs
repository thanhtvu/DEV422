using Microsoft.AspNetCore.Mvc;

namespace RentalMusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        // Create a list for all rentals
        private static List<Rentals> rentals = new List<Rentals>();

        // POST: Rent a music album (requires user ID and album ID)
        [HttpPost]
        public ActionResult RentMusic(int userId, int albumId)
        {
            var rental = new Rentals
            {
                UserId = userId,
                AlbumId = albumId,
                RentalDate = DateTime.Now
            };
            rentals.Add(rental);
            return Ok("Music album rented successfully");
        }

        // POST /api/rentals/{albumId}: Return a music album - remove from the list
        [HttpPost("{albumId}/return")]
        public ActionResult ReturnAlbum(int albumId)
        {
            var rental = rentals.FirstOrDefault(r => r.AlbumId == albumId);
            if (rental == null)
            {
                return NotFound("Rental not found");
            }
            rental.ReturnDate = DateTime.Now;
            return Ok("Music album returned successfully");
        }

        // GET: List all active rentals
        [HttpGet]
        public ActionResult<List<Rentals>> GetAllRentals()
        {
            return Ok(rentals);
        }
    }
}
