using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Read the JWT secret code from configuration and convert to bytes
var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:SecretKey"]);

// Configure JWT authentication
builder.Services.AddAuthentication(options =>
{
    //set the default authencation scheme to JWT
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    // set the default challenge scheme to JWT
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}
).AddJwtBearer(options =>
{
    //Configure the parameters for validating tokens
    options.TokenValidationParameters = new TokenValidationParameters
    {
        // Specify that the signing key should be validated
        ValidateIssuerSigningKey = true,

        // Set the key used to validate the token's signature
        IssuerSigningKey = new SymmetricSecurityKey(key),


        // Disable issuer validation
        ValidateIssuer = false,
        ValidateAudience = false
    };

});



var app = builder.Build();



app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
