using FantasySport.Application.Interfaces.Repositories;
using FantasySport.Application.Interfaces.Services;
using FantasySport.Application.Services;
using FantasySport.DataAccess;
using FantasySport.DataAccess.Repositories;
using FantasySport.Infastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API with API Key Authentication",
        Version = "v1"
    });

    options.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        Description = "Enter API-key in format 'X-Api-Key: {your key}'",
        Name = "X-Api-Key",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "ApiKeyScheme"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "ApiKey"
                }
            },
            new List<string>()
        }
    });
});
builder.Services.AddHttpClient();


#region [ DI Repositories ]
builder.Services.AddScoped<ITeamsRepository, TeamsRepository>();
#endregion
#region [ DI Services ]
builder.Services.AddScoped<ITeamsService, TeamsService>();
#endregion

builder.Configuration.AddEnvironmentVariables();
#if DEBUG
builder.Services.AddDbContext<FantasySportDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(FantasySportDbContext)));
});
#else
builder.Configuration.AddEnvironmentVariables();
builder.Services.AddDbContext<FantasySportDbContext>(options =>
{
    var connectionString = Environment.GetEnvironmentVariable("SQLAZURECONNSTR_FantasySportDbContext");
    options.UseSqlServer(connectionString);
});
#endif
builder.Services.AddAuthorization();
var app = builder.Build();

app.UseMiddleware<ApiKeyMiddleware>();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
    options.RoutePrefix = "swagger";
});

app.MapControllers();
app.Run();
