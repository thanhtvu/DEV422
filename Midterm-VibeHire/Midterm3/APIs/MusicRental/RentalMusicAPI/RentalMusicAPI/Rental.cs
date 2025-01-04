namespace RentalMusicAPI
{
    public class Rentals
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
