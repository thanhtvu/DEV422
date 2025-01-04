namespace BorrowingManagementAPI
{
    public class Borrowing
    {
        // Step1: Need to create the Borrowing Objects
        public int UserID { get; set; }
        public int BookID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
