using Microsoft.AspNetCore.Mvc;

namespace BookManagementAPI.Controllers
{
    
        [ApiController]

        [Route("api/[controller]")]

        public class BookController : ControllerBase { 

            // save/store books - List
            private static List<Book> books = new List<Book>();

            // getall books
            [HttpGet]
            public ActionResult<List<Book>> GetBooks()
            {
                return Ok(books);
            }


            // add - adding book to the list
            [HttpPost]
            public ActionResult AddBook(Book book)
            {
                book.Id = books.Count + 1;
                books.Add(book);
                return Ok("Book Added successfully.");
            }


            // delete - deleting book from the list
            [HttpDelete("{id}")]
            public ActionResult DeleteBook(int id)
            {
                var book = books.FirstOrDefault(b => b.Id == id); //?
                if (book == null)
                {
                    return NotFound("Book not Found.");
                }

                books.Remove(book);
                return Ok("Book Removed successfully.");
            }


        }


    }

