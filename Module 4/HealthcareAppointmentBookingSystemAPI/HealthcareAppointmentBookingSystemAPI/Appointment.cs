namespace HealthcareAppointmentBookingSystemAPI
{
    public class Appointment
    {

        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public string? Status { get; set; } // status (Pending, Confirmed, Canceled)

    }
}
