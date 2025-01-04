using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
//using HealthcareAppointmentBookingSystemAPI.Models;
//using HealthcareAppointmentBookingSystemAPI.Services;

namespace HealthcareAppointmentBookingSystemAPI.Controllers
{

    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]


    public class AppointmentsController : ControllerBase
    {

        private readonly AppointmentService _appointmentService;

        public AppointmentsController(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }


        // Patient books an appointment 
        [Authorize(Policy = "RequirePatientRole")]
        [HttpPost("book")]

        public IActionResult BookAppointment (Appointment appointment)
        {
            // default stauts
            appointment.Status = "Pending";

            // add the appointment
            _appointmentService.CreateAppointment(appointment);


            return Ok("Appointment booked successfully with status: Pending");
        }



        // Doctor or Admin updates an appointment's details or status
        [Authorize(Policy = "RequireDoctorRole,RequireAdminRole")]
        [HttpPut("update/{id}")]
        public IActionResult UpdateAppointment(int id, [FromBody] Appointment updatedAppointment)
        {
            var appointment = _appointmentService.GetAppointmentById(id);
            //
            if (appointment == null)
            {
                return NotFound();
            }
            

            appointment.Date = updatedAppointment.Date;
            // update the Status to Confirmed or Cancel
            appointment.Status = updatedAppointment.Status; 
            _appointmentService.UpdateAppointment(appointment);

            return Ok($"Appointment updated successfully with status: {appointment.Status}");
        }



        // Patient/Doctor/Admin can view specific appointments based on roles
        [Authorize(Policy = "RequireDoctorRole,RequirePatientRole")]
        [HttpGet("view/{id}")]
        public IActionResult ViewAppointment(int id)
        {
            var appointment = _appointmentService.GetAppointmentById(id);
            // chefk if the appointment exists?
            if (appointment == null)
            {
                return NotFound();
            }
            

            return Ok(appointment);
        }

        // Doctor/Admin cancels an appointment
        [Authorize(Policy = "RequireDoctorRole,RequirePatientRole")]
        [HttpDelete("cancel/{id}")]
        public IActionResult CancelAppointment(int id)
        {
            var appointment = _appointmentService.GetAppointmentById(id);
            //
            if (appointment == null)
            {
                return NotFound();
            }

            // Set status to Canceled
            appointment.Status = "Canceled"; 
            _appointmentService.UpdateAppointment(appointment);

            return Ok("Appointment canceled successfully");
        }

    }
}
