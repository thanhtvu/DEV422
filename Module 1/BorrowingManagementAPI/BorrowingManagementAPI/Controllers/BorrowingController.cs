// Step2: Create this Controller

using Microsoft.AspNetCore.Mvc;

namespace BorrowingManagementAPI.Controllers
{

    // Step3: add these lines below
    [ApiController]
    [Route("api/[controller]")]

    // Step4: Create ControllerBase below
    public class BorrowingController : ControllerBase
    {
        
        // Step 5: Ceate the List of borrowing *below*
        private static List<Borrowing> Borrowings = new List<Borrowing>();

        //  Add to the list - borrowBook
        [HttpPost]
        public ActionResult BorrowBook(int userID, int bookID)
        {
            // create an object
            var borrowing = new Borrowing
            {
                UserID = userID,
                BookID = bookID,
                BorrowDate = DateTime.Now,
                // ReturnDate = null,
            };
            // add the object t the list
            Borrowings.Add(borrowing);
            return Ok("Book borrowed successfully!");
        }


        // Remove from the list - ReturnBook
        [HttpPost("{bookID}")]
        public ActionResult ReturnBook (int bookID)
        {
            // create an object
            var borrowing = Borrowings.FirstOrDefault(b => b.BookID == bookID );
            if (borrowing == null)
            {
                return NotFound("Borrowing record not Found!");
            }

            borrowing.ReturnDate = DateTime.Now;

            return Ok("Book returned successfully!");
        }


        // getallborrowings
        [HttpGet]
        public ActionResult<List<Borrowing>> GetAllBorrowings()
        {
            return Ok(Borrowings);
        }


        // get borrowing based on user id
        [HttpGet("user/{userID}")]
        public ActionResult<List<Borrowing>> GetUserBorrowing(int userID)
        {
            var userBorrowing = Borrowings.Where(x => x.UserID == userID).ToList();

            if (userBorrowing.Count == 0) {
                return NotFound("No Borrowings found for this user!");
            }

            return Ok(userBorrowing);
        }

        
        
    }
}
