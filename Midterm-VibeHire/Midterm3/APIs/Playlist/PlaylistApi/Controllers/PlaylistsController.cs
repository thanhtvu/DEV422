using Microsoft.AspNetCore.Mvc; // imports the ASP.NET Core MVC framework
using PlaylistApi.Models;
using PlaylistApi.Services;

using System.Collections.Generic; // import collections like List and Dictionary
using System.Linq; // imports LINQ for easier data querying & manipulation




namespace PlaylistApi.Controllers
{

    [ApiController]
    [Route("api/playlists")]


    public class PlaylistsController : ControllerBase
    {

        // Declares new read-only service to handle playlist logic
        private readonly PlaylistService _playlistService;

        // Inject constructor for PlaylistService
        public PlaylistsController ()
        {
            _playlistService = new PlaylistService(); // initialize the playlist service
        }


        // HTTTP POST - For creating a new playlist
        [HttpPost]
        public ActionResult<Playlist> CreatePlaylist([FromBody] Playlist playlist) // what is this [FromBody]?
        {
            // calls the service to add the playlist
            _playlistService.CreatePlaylist(playlist);

            // return 201 response (look this up!) with created playlist
            return CreatedAtAction(nameof(GetPlaylist), new { id = playlist.Id }, playlist);
        }



        // http get -   For retrieving ALL playlists
        [HttpGet]
        public ActionResult<List<Playlist>> GetAllPlaylist()
        {
            // calls the service _playlistService to gell all playList
            return _playlistService.GetAllPlaylist();
        }



        // Http GET with 'id' to retieve a specific playlist by Id
        [HttpGet("{id}")]
        public ActionResult<Playlist> GetPlaylist(int id)
        {
            // calls the service above to get a playlist by it's Id
            var playlist = _playlistService.GetPlaylistById(id);

            // check if that playlist exist
            if (playlist == null)
            {
                return NotFound(); // return 404
            }

            // or 
            return playlist;
        }



        // Http PUT with 'id' to add a song to a playlist
        [HttpPut("{id}/add")]
        public IActionResult AddSongToPlaylist (int id, [FromBody] Song song)
        {
            // calls service to add a song to playlist
            var result = _playlistService.AddSongToPlaylist(id, song);

            // check if the operation was successful
            if (!result)
            {
                return NotFound(); // 404
            }

            return NoContent(); // 204 - successful update
        }



        // Http PUT with 'id' to invite a collaborator with an id
        [HttpPut("{id}/invite")]
        public IActionResult InviteCollaborator (int id, [FromBody] int userId)
        {
            // calls the service to invite the collaborator
            var result = _playlistService.InviteCollaborator(id, userId);

            // check if the operation was successful
            if (!result)
            {
                return NotFound(); // 404
            }

            return NoContent(); // 204 - successful update
        }



        // Http POST with 'id' to vote on a song
        [HttpPost("{id}/vote")]
        public IActionResult VoteOnSong (int id, [FromBody] int songId)
        {
            // call the service to vote on the song
            var result = _playlistService.VoteOnSong(id, songId);

            // check if the operation was successful
            if (!result)
            {
                return NotFound(); // 404
            }

            return NoContent(); // 204 - successful update
        }



        // Http GET with 'id' to get the ranking of a playlist
        [HttpGet("{id}/rankings")]
        public ActionResult<List<Song>> GetSongRankings(int id)
        {
            // calls service
            var rankings = _playlistService.GetSongRankings(id); 


            if (rankings == null) 
            {
                return NotFound(); 
            }
            return rankings;
        }
       

    }
}
