using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace RentalServiceAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class RentalController : ControllerBase
    {
        // Start-number of RentalId
        private static int count = 1;

        private static readonly HttpClient client = new HttpClient();
        // Create a List of all Rentals
        private static List<Rental> RentalList = new List<Rental>();


        // Rent a movie (requires customer ID and movie ID)
        [HttpPost]
        public async Task<ActionResult> RentMovieAsync ([FromBody] RentalRequest request)
        {
            var customerId = request.CustomerId;
            var movieId = request.MovieId;
            Console.WriteLine("customerId" + customerId);
            Console.WriteLine("movieId" + movieId);
            HttpResponseMessage message = await client.GetAsync("https://localhost:7044/api/Customer");
            string jsonString = await message.Content.ReadAsStringAsync();
            var CustomerList = JsonConvert.DeserializeObject<List<Customer>>(jsonString);

            HttpResponseMessage message1 = await client.GetAsync("https://localhost:7171/api/Movie");
            string jsonString1 = await message1.Content.ReadAsStringAsync();
            var MovieList = JsonConvert.DeserializeObject<List<Movie>>(jsonString1);
         
            var customer = CustomerList?.FirstOrDefault(c => c.CustomerID == customerId);
            var movie = MovieList?.FirstOrDefault(m => m.MovieID == movieId);
            Console.WriteLine("dsfdsfsdfsdfsdfsdfsdfsdfsdfsdfsdfdsfdsfd");
            Console.WriteLine(String.Join(", ", CustomerList));
            if (customer == null)
            {
                return NotFound("Customer NOT Found!");
            }
            if (movie == null)
            {
                return NotFound("Movie NOT Found");
            }
            if (!movie.Available)
            {
                return NotFound("Movie is NOT Available for Rent");
            }
            // Mark the movie as rented (unavailable)
            movie.Available = false; // this to prevent the movie being rented


            // Otherwise, we rent it
            var rental = new Rental
            {
                CustomerId = customerId,
                MovieId = movieId,
                RentalId = count,
                RentalDate = DateTime.Now,
                ReturnDate = null      // it has not been returned yet
            };

            // -> Add new Rental to the RentalList
            RentalList.Add(rental);

            // Increase RentalId
            count++;


            return Ok("Movie Rented Successfully!");

        }


        // Return a movie 
        [HttpPost("{movieId}")]
        public async Task<ActionResult> ReturnMovieAsync(int movieId)
        {
            Console.WriteLine("movieId" + movieId);
            // Find the rental based on the Movie List
            var rental = RentalList.FirstOrDefault(r =>  r.MovieId == movieId && r.ReturnDate == null);

            if (rental == null)
            {
                return Ok("Rental NOT Found or Movie already Returned!");

            }

            // Find the movie
            HttpResponseMessage message1 = await client.GetAsync("https://localhost:7171/api/Movie");
            string jsonString1 = await message1.Content.ReadAsStringAsync();
            var MovieList = JsonConvert.DeserializeObject<List<Movie>>(jsonString1);
            var movie = MovieList?.FirstOrDefault(m => m.MovieID == movieId);
            if (movie == null)
            {
                return NotFound("Movie not found!");
            }

            // Mark the movie as available
            //HttpResponseMessage message = await client.PostAsync($"https://localhost:7259/api/Movie?userId={userID}&bookId={bookID}", null)
            movie.Available = true;

            // Set the return date for the rental
            rental.ReturnDate = DateTime.Now;

            return Ok("Movie returned successfully!");

        }



        // List all active rentals
        [HttpGet]
        public ActionResult<List<Rental>> GetAllActiveRentals()
        {
            // Return only rentals that haven't been returned yet
            var activeRentals = RentalList.Where(r => r.ReturnDate == null).ToList();

            if (!activeRentals.Any())
            {
                Ok("No active rentals found.");
            }

            return Ok(activeRentals);
        }






    }
}
