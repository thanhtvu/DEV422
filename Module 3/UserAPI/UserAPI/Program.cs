
using UserAPI;
using UserAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddSingleton<UserApi>(); // added


var app = builder.Build();

app.MapGrpcService<UserApi>();// replaced the old code with this


app.Run();
