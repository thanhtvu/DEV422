using Azure.Storage.Blobs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Add MVC services to dependency injection container

// Register BlobServiceClient as singleton service
// Same instance will be used throughout the application's lifetime

builder.Services.AddSingleton(x =>
{
    var connectionString = builder.Configuration.GetSection("BlobStorage")["ConnectionString"];

    return new BlobServiceClient(connectionString);
});

var app = builder.Build();




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Blob}/{action=Index}/{id?}");

app.Run();
