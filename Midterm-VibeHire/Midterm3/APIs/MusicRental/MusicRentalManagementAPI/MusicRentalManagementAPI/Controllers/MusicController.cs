using Microsoft.AspNetCore.Mvc;

namespace MusicRentalManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : ControllerBase
    {
        // Save music album in list in memory
        private static List<Music> musicList = new List<Music>();

        // POST: Add a new music album
        [HttpPost]
        public ActionResult AddMusic(Music music)
        {
            music.Id = musicList.Count + 1;
            musicList.Add(music);
            return Ok("Music album added successfully");
        }

        // GET: List all available music albums
        [HttpGet]
        public ActionResult <List<Music>> GetMusic()
        {
            return Ok(musicList);
        }

        // DELETE: Delete a music album by its ID
        [HttpDelete("{id}")]
        public ActionResult DeleteMusic(int id)
        {
            var music = musicList.FirstOrDefault(m => m.Id == id);
            if (music == null)
            {
                return NotFound("Music album not found");
            }
            musicList.Remove(music);
            return Ok("Music album deleted successfully");
        }
    }
}
