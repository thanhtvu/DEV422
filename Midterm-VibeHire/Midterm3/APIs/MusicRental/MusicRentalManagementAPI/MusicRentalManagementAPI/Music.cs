namespace MusicRentalManagementAPI
{
    public class Music
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }
        public bool isAvailable { get; set; }
    }
}
