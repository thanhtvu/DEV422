using BookAPI;
using BookAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddSingleton<BookAPI.BookApi>();



var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<BookAPI.BookApi>();

app.Run();
