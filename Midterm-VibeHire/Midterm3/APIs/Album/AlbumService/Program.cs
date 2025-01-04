using AlbumService.Services;

namespace AlbumService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddGrpc();
            builder.Services.AddSingleton<AlbumService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<AlbumService>();

            app.Run();
        }
    }
}