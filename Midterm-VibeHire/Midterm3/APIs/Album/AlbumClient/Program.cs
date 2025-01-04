using Grpc.Net.Client;

namespace AlbumClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /*using var channel = GrpcChannel.ForAddress("https://localhost:7202");

            var client = new Album.AlbumClient(channel);

            Console.WriteLine("Client: Creating album...");
            var createResponse = await client.AddAlbumAsync(new AddAlbumRequest { Title = "Ballads", Artist = "Grant Green", Genre = "Jazz", Year = 2002, Available = true});
            Console.WriteLine($"Client: Created album with ID: {createResponse.AlbumId}");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();*/
        }
    }
}
