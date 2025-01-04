namespace HealthcareAppointmentBookingSystemAPI
{
    public class User  // here tp define User model
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // User's role (Admin, Doctor, Patient)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
