//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Grpc.Net.Client;
//using System;
using System.Threading.Tasks;
//using System.Linq.Expressions;
using BookApi;
using Grpc.Core;
using System;




class Program
    {
    static async Task Main(string[] args)
    {
        // Create a gPRC channel to communicate with the server
        using var channel = GrpcChannel.ForAddress("https://localhost:7152");

        // create a client instance to interact with the Book Service
        var client = new BookService.BookServiceClient(channel);



        //// Call AddBook method
        //var newBook = new Book
        //{
        //    Id = 1,                   // Assign unique ID
        //    Title = "Sample Book",     // Book title
        //    Author = "John Doe",       // Author's name
        //    PublicationYear = 2023    // Publication year
        //};

        //var addBookRequest = new AddBookRequest { Book = newBook };

        //// Send the AddBook request to the server
        //var response = await client.AddBookAsync(addBookRequest);

        //// Display the response message from the server
        //Console.WriteLine(response.Message);

        //// Dispose the channel when done
        //await channel.ShutdownAsync();

        try
        {
            var count = 1;
            // Create a new user for the API
            Console.WriteLine("Client: Creating a new book...");
            var newBook = new Book
            {
                Id = count,                   // Assign unique ID
                Title = "Sample Book " + count,     // Book title
                Author = "John Doe " + count,       // Author's name
                PublicationYear = 2023    // Publication year
            };
            count++;

            var addBookRequest = new AddBookRequest { Book = newBook };
            var response = await client.AddBookAsync(addBookRequest);

            Console.WriteLine($"Client: {response.Message}");


            Console.WriteLine("Press A key to Add a Book.");
            Console.WriteLine("Press U key to Update a Book.");
            Console.WriteLine("Press L key to List All Books.");
            Console.WriteLine("Press D key to Delete a Book.");
            Console.WriteLine("Press Q key to End.");
            var keyObj = Console.ReadKey();
            Console.WriteLine();
            while (keyObj.KeyChar != 'Q') { 
                if (keyObj.KeyChar == 'A')
                {
                    newBook = new Book
                    {
                        Id = count,                   // Assign unique ID
                        Title = "Sample Book " + count,     // Book title
                        Author = "John John " + count,       // Author's name
                        PublicationYear = 2024    // Publication year
                    };
                    count++;

                    addBookRequest = new AddBookRequest { Book = newBook };
                    response = await client.AddBookAsync(addBookRequest);

                    Console.WriteLine($"Client: {response.Message}");
                }
                else if (keyObj.KeyChar == 'U')
                {
                    var updateBookRequest = new UpdateBookRequest
                    {
                        Book = new Book
                        {
                            Id = 1, // ID of the book you want to update
                            Title = "Updated Title",
                            Author = "Updated Author",
                            PublicationYear = 2024 // Be sure the field is correct (check spelling too)
                        }
                    };

                    //response = await client.UpdateBookAsync(updateBookRequest);
                    Console.WriteLine($"Client: Updated successfully");
                }
                else if (keyObj.KeyChar == 'L')
                {
                    //addBookRequest = new List { Book = newBook };
                    //response = await client.ListBooks(new Empty());

                    Console.WriteLine($"Client: List here successfully");
                }
                else if (keyObj.KeyChar == 'D')
                {
                    //addBookRequest = new List { Book = newBook };
                    //response = await client.ListBooks(new Empty());

                    Console.WriteLine($"Client: Delete Book successfully");
                }
            Console.WriteLine("Press A key to Add a Book.");
            Console.WriteLine("Press U key to Update a Book.");
            Console.WriteLine("Press L key to List All Books.");
            Console.WriteLine("Press D key to Delete a Book.");
            Console.WriteLine("Press Q key to End.");
            keyObj = Console.ReadKey();
            Console.WriteLine();

            }

        }
        catch (Grpc.Core.RpcException ex)
        {
            Console.WriteLine($"Client: gRPC error: {ex.Status.StatusCode} - {ex.Status.Detail}");
        }
        



    }



    }

