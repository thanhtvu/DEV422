using RealTimeChatApp;


var builder = WebApplication.CreateBuilder(args);


// create the builder
builder.Services.AddSignalR().AddAzureSignalR("Endpoint=https://terrychatlatest.service.signalr.net;AccessKey=AYKxaZXYk7lDnYqe9kb31znXUqcLubVf4iizojFweDs1pcYrdYJHJQQJ99AKAC4f1cMXJ3w3AAAAASRS2ncI;Version=1.0");


var app = builder.Build();

// Map SignalR hubs
app.MapHub<ChatHub>("/chat");


// Set index.html as the default file
app.MapFallbackToFile("index.html");

app.Run();
