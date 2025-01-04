namespace RentalServiceAPI
{
    public class RentalRequest
    {
        public int CustomerId { get; set; }
        public int MovieId { get; set; }
    }
    public class Rental
    {
        public int CustomerId { get; set; }
        public int MovieId { get; set; }
        public int RentalId {  get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }

    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public bool Available { get; set; }

    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }


}
