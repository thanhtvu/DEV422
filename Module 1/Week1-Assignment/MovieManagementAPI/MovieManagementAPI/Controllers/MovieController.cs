using Microsoft.AspNetCore.Mvc;

namespace MovieManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MovieController : ControllerBase
    {

        // List of saved/stored Movies
        private static List<Movie> MovieList = new List<Movie>();

        // Add a new Movie
        [HttpPost]
        public ActionResult AddNewMovie(Movie movie)
        {
            movie.MovieID = MovieList.Count + 1;
            MovieList.Add(movie);
            return Ok("Movie Added Sucessfully.");
        }


        // List all available movies
        [HttpGet]
        public ActionResult<List<Movie>> ListAllMovie()
        {
            //MovieList.Clear();
            return Ok(MovieList);
        }


        // Delete a movie by its MovieID
        [HttpDelete("{movieId}")]
        public ActionResult DeleteMovieById(int movieId)
        {
            var movie = MovieList.FirstOrDefault(m => m.MovieID == movieId); //?
            if (movie == null)
            {
                return NotFound("Movie NOT Found.");
            }
            MovieList.Remove(movie);
            return Ok("Movie Removed Successfully.");
        }





    }
}
