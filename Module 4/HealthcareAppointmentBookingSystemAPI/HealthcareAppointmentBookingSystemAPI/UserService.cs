using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;



namespace HealthcareAppointmentBookingSystemAPI


{
    public class UserService
    {

        // in real application, this would be replaced with the database
        public static readonly List<User> users = new List<User>();

        // Register a new user
        public void Register (User user)
        {
            users.Add(user); // add new user to the list above
        } 


        // Retrieve user by userName
        public User GetUserByUsername(string userName)
        {
            return users.FirstOrDefault(u => u.Username == userName);
        }

        public void UpdateUser(User user) // Update user details
        {
            // Assuming users is the list of users where changes are persisted
            var existingUser = users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.FirstName = user.FirstName;
                existingUser.LastName = user.LastName;
                existingUser.Email = user.Email;
                existingUser.Role = user.Role;
                // Save the changes in persistent storage
            }
        }

        public void ChangePassword(User user, string newPassword) // Change password
        {
            user.Password = HashPassword(newPassword);
            // Save the new password in persistent storage
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            // Hash the input password
            var hashedInput = HashPassword(password);
            //Compare the hashed input with stored hashed password
            return hashedInput == hashedPassword;
        }

        // helper function to hass passwords using SHA256
        public string HashPassword(string password)
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
