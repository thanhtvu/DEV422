// using BookAPI;
using Grpc.Core;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using BookApi;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BookAPI
{
    public class BookApi : BookService.BookServiceBase
    {

        // Dictionary to store books, shared across all instance of Book
        private static readonly ConcurrentDictionary<int, BookResponse> books = new();



        // AddBook - mthod to add book
        public override Task<AddBookResponse> AddBook(AddBookRequest request, ServerCallContext context)
        {
            // get book from request
            var book = request.Book;

            // add book if ID is unique
            if (!books.TryAdd(book.Id, new BookResponse { Book = book }))
            {
                throw new RpcException(new Status(StatusCode.AlreadyExists, $"Book with ID {book.Id} already exists.")); // error if books already exists

            }

            // 
            return Task.FromResult(new AddBookResponse { Message = "Book ADDED successfully with ID " + book.Id });
        }



        // GetBook - method to get the book by bookId 
        public override Task<BookResponse> GetBook(BookRequest request, ServerCallContext context)
        {
            // check if the book exists
            if (books.TryGetValue(request.BookId, out var book))
            {
                return Task.FromResult(book);
            } else
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Book with ID {request.BookId} not found.")); // Error if not found 
            }
        }



        // UpdateBook - updates an existing book's information
        public override Task<Empty> UpdateBook(UpdateBookRequest request, ServerCallContext context)
        {
            var updatedBook = request.Book;    // get the updatedBook object from the request

            // check if the book with the given Id exists in the dictionary
            if (books.TryGetValue(updatedBook.Id, out var existingBook))
            {
                // if book exists, update it in the dictionary with the new data
                books[updatedBook.Id] = new BookResponse { Book = updatedBook };

                // return an empty response indicating success
                return Task.FromResult(new Empty());
            }
            else
            {
                // if the book is not found, throw an error
                throw new RpcException(new Status(StatusCode.NotFound, $"Book with ID {updatedBook.Id} NOT found."));
            }
        }



        // DeleteBook - removes a book from the inventory
        public override Task<Empty> DeleteBook(DeleteBookRequest request, ServerCallContext context)
        {
            if (books.TryRemove(request.Id, out var _))
            {
                return Task.FromResult(new Empty());
            }
            else
            {
                // error if not found
                throw new RpcException(new Status(StatusCode.NotFound, $"Book with ID {request.Id} not found."));  
            }

        }




        // ListBooks - returns a stream of all books in the inventory
        public override async Task ListBooks(Empty request, IServerStreamWriter<BookResponse> responseStream, ServerCallContext context)
        {
            // iterate over all books
            foreach (var book in books.Values)
            {
                await responseStream.WriteAsync(book); // steam each book to client
            }


        }



    }
}
