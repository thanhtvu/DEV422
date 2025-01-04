using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
//using HealthcareAppointmentBookingSystemAPI.Models;


namespace HealthcareAppointmentBookingSystemAPI
{

    // Generates JWT tokens
    public class JwtService
    {

        private readonly string _key;


        // accepts key for token signing
        public JwtService (string key)
        {
            _key = key;
        }


        // generates token based on user data
        public string GenerateToken (User user)
        {
            var claims = new[]
            {
                // adds role claim to token
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role)
            };

            // EXPLAIN THESE LINES??? & NOTE THESE DOWN!
            // generate security key from secret
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
            // set signing credentials
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "HealthCareAppointmentAPI",
                audience: "HealthCareAppointmentAPI",
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
                );

            // return the token as string
            return new JwtSecurityTokenHandler().WriteToken(token);

        }





    }
}
