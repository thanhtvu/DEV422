namespace PlaylistApi.Models
{
    public class Playlist
    {

        public int Id { get; set; }
        public string Name { get; set; }
        //public List<int> SongsId { get; set; } = new List<int>(); // List of song's IDs
        public int CreateBy { get; set; } // ID of the user who created the list
        public bool IsCollaborative { get; set; } // Allows collaboration or not?
        public List<int> Collaborators { get; set; } = new List<int>(); // List of Collaborator's IDs

        // 
        public List<Song> Songs { get; set; } = new List<Song>();

    }
}
