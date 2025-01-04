using System.Collections.Generic;




namespace HealthcareAppointmentBookingSystemAPI
{
    public class AppointmentService
    {
        // Store appointments in a list
        private readonly List<Appointment> _appointments = new List<Appointment>();

        //// Add appointments
        //public void AddAppointment(Appointment appointment) => _appointments.Add(appointment);


        // Create a new appointment
        public void CreateAppointment(Appointment appointment)
        {
            // set unique ID
            appointment.Id = _appointments.Count > 0 ? _appointments.Max(a => a.Id) + 1 : 1;
            //
            _appointments.Add(appointment);
        }



        // Retrieve an appointment by Id
        public Appointment GetAppointmentById(int id)
        {
            // find the matching Id appointment
            return _appointments.FirstOrDefault(a => a.Id == id);
        }


        // Updating an existing appoinment
        public void UpdateAppointment(Appointment updatedAppointment)
        {
            // find & store the appointment
            var appointment = _appointments.FirstOrDefault(a => a.Id == updatedAppointment.Id);

            // if the appointment exist!
            if (appointment != null)
            {
                appointment.Date = updatedAppointment.Date;
                appointment.Status = updatedAppointment.Status; // Update the status as well
            }
        }


        // Retrieve all appointments
        public List<Appointment> GetAllAppointments()
        {
            return _appointments;
        }



        // Delete or Cancel an appointment by setting its status to "Canceled"
        public void CancelAppointment(int id)
        {
            // find & store the appointment
            var appointment = _appointments.FirstOrDefault(a => a.Id == id);
            // if that appointment is excist
            if (appointment != null)
            {
                appointment.Status = "Canceled";
            }
        }
    }
}
