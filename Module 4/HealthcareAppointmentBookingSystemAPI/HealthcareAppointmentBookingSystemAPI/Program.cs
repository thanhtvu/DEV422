using HealthcareAppointmentBookingSystemAPI;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
//using HealthcareAppointmentBookingSystemAPI.Services;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();


// Read thee JWT secret code from configuration and convert to bytes
var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:SecretKey"]);

// Register the JwtService with the Secret Key
builder.Services.AddSingleton(new JwtService(builder.Configuration["Jwt:Secretkey"]));


// Configure JWT authentication
builder.Services.AddAuthentication(options =>
{
    // set the default authentication scheme to JWT
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    // set the deffault challenge scheme to JWT
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;



}).AddJwtBearer(options =>
{
    // Configure the parameters for validating tokens
    options.TokenValidationParameters = new TokenValidationParameters
    {
        // specify that the signing key should be validated
        ValidateIssuerSigningKey = true,

        // set thje key used to validate the token's signature
        IssuerSigningKey = new SymmetricSecurityKey(key),

        // disable issuer validation
        ValidateIssuer = false,
        ValidateAudience = false,


    };

});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
    options.AddPolicy("RequireDoctorRole", policy => policy.RequireRole("Doctor"));
    options.AddPolicy("RequirePatientRole", policy => policy.RequireRole("Patient"));
});


// Add other services
builder.Services.AddSingleton<UserService>();


var app = builder.Build();



app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
