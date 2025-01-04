using HealthcareAppointmentBookingSystemAPI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace SecurityApi.Controllers
{
    // Define the route template for this controller 
    [Route("api/[controller]")]

    // Indicate that this is an API controller
    [ApiController]
    public class AuthController : ControllerBase
    {
        // Store the JWT secret key
        private readonly string _secretKey;

        // in real application, this would be replaced with the database
        private List<User> users;

        public AuthController(IConfiguration configuration)
        {
            _secretKey = configuration["Jwt:SecretKey"];
            users = UserService.users;
        }


        //registration
        [HttpPost("register")]
        public IActionResult Register([FromBody]User user)
        {
            // check if username or password is missing
            if(string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password) )
            {
                //Return 400 Bad request if validation fails
                return BadRequest("Username and password are required for registration");
            }

            // check if a user with the same username already exists
            if(users.Any(x => x.Username == user.Username))
            {
                //Return 400 bad request if username is taken
                return BadRequest("Username already exist");
            }

            // Hash the user's password for security
            user.Password = HashPassword(user.Password);

            // Add the new user to our in-memory storage || database in real world
            users.Add(user);

            // Return 200 OK with the success message
            return Ok(new {Message = "Registration successful"});
        }



        //login
        [HttpPost("login")]
        public IActionResult Login([FromBody]UserLogin userLogin) 
        {

            // Try to find the user by username
            var user = users.FirstOrDefault(x => x.Username == userLogin.Username);

            // Check if user exists and password is correct
            if(user == null ||  !VeriftyPassword(userLogin.Password, user.Password)) 
            {
                // return 401 message
                return Unauthorized("Invalid Credentials");
            }

            // Create a new JWT token handler
            var tokenHandler = new JwtSecurityTokenHandler();

            // Convert the secret key to bytes
            var key = Encoding.ASCII.GetBytes(_secretKey);

            // configure the token's properties
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    // Standard claims
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Email, user.Email ?? ""),
                    // Custom claims
                    new Claim("FirstName", user.FirstName ?? ""),
                    new Claim("LastName", user.LastName ?? ""),
                    new Claim("Role", user.Role ?? "")
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                // set the signing credentials 
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)

            };

            // Create the JWT Token
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // Convert the token to a string
            var tokenString = tokenHandler.WriteToken(token);

            // Return 200 success message to the user with the token
            return Ok(new {Token = tokenString});

        }
         

        // helper fucntion to verify password

        private bool VeriftyPassword(string password, string hashedPassword)
        {
            // Hash the input password
            var hashedInput = HashPassword(password);
            //Compare the hashed input with stored hashed password
            return hashedInput == hashedPassword;
        }
   
        // helper function to hass passwords using SHA256
        private string HashPassword(string password)
        {
            //Create a new SHA256 instance
            using (var sha256 = SHA256.Create())
            {
                //convert the password to bytes and compute hash
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                // Convert the hashed bytes to a base64 string
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
