using PlaylistApi.Models; // Impor Playlist.cs & Song.cs from Models folder
using System.Collections;
using System.Linq;



namespace PlaylistApi.Services
{
    public class PlaylistService
    {

        // Create an In-memory List of playlists
        private static readonly List<Playlist> _playlists = new List<Playlist>();



        // Add new playlist
        public void CreatePlaylist (Playlist playlist)
        {
            // sets playlist ID based on the Count of existing playlists
            playlist.Id = _playlists.Count + 1;

            // add that playlist to the In-memory List
            _playlists.Add(playlist);
            Console.WriteLine(_playlists.Count);
        }


        // Method - Retrieve all playlists
        public List<Playlist> GetAllPlaylist()
        {
            Console.WriteLine(_playlists.Count);
            return _playlists;
        }



        // Method - Retrieve a playlist by Id (type Playlist)
        public Playlist GetPlaylistById(int id)
        {
            // look up that "FirstOrDefault" 
            return _playlists.FirstOrDefault(p => p.Id == id);
        }




        // Method - Add a song to a playlist by playlist's Id
        public bool AddSongToPlaylist (int playlistId, Song song)
        {
            // assign a Playlist for this method, using method above
            var playlist = GetPlaylistById(playlistId); 

            // check if that Playlist exists or Not?
            if (playlist == null)
            {
                throw new Exception("Playlist not found");
            }

            // else, give the "desired to add"-song an Id based on the current count in playlist
            song.Id = playlist.Songs.Count + 1; 

            // add that song to the playlist
            playlist.Songs.Add(song);

            return true; // add song successfully

        }



        // Method - Invite a collaborator by that user's Id
        public bool InviteCollaborator (int playlistId, int userId)
        {
            // finds the playlist by it's Id
            var playlist = GetPlaylistById (playlistId);

            // check if the playlist is found or not?
            if ( playlist == null )
            {
                return false;
            }

            // check if user is already a collaborator or not
            if (!playlist.Collaborators.Contains (userId)) // if he is not 
            {
               playlist.Collaborators.Add (userId); // then add him/her
            }

            return true; // operation successful
        }



        // Method - Vote on a song in a playlist
        public bool VoteOnSong (int playlistId, int songId)
        {
            // finds the playlist by it's Id
            var playlist = GetPlaylistById(playlistId);
            
            // check if the playlist is found or not
            if (playlist == null )
            {
                return false; // it is not found 
            }

            // finds the song by songId
            var song = playlist.Songs.FirstOrDefault (s => s.Id == songId);

            // check if that song is found?
            if (song == null)
            {
                throw new Exception("Song not found in playlist");
            }

            // increment the vote count
            song.Votes++; // where is this Vote come from???

            return true; 

        }




        // Method - Get ranked songs based on votes
        public List<Song> GetSongRankings (int playlistId)
        {
            // fins the playlist by it's Id
            var playlist = GetPlaylistById(playlistId);

            // check if the playlist is found or not 
            if (playlist == null)
            {
                throw new Exception("Playlist not found");
            }

            // sorts songs by vote counts in decending order
            var rankedSongs = playlist.Songs.OrderByDescending(s => s.Votes).ToList();

            return rankedSongs;
            
        }










    }
}
