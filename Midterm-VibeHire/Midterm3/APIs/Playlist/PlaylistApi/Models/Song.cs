namespace PlaylistApi.Models
{
    public class Song
    {
        public int Id { get; set; } // The ID of the song
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public double Duration { get; set; } // Song's duration in minutes
        public int Votes { get; set; } // for collabotive voting


    }
}
