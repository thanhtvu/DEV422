using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//using HealthcareAppointmentBookingSystemAPI.Models;
//using HealthcareAppointmentBookingSystemAPI.Services;



namespace HealthcareAppointmentBookingSystemAPI.Controllers
{

    // Explain these 2 lines after & NOTE THEM DOWN!
    [Route("api/[controller]")]
    [ApiController]
    // This attribute requires a valid JWT token for all endpoints
    [Authorize]

    public class UsersController : ControllerBase
    {

        private readonly UserService _userService; // where is UserService & _userService comefrom?
        //
        public UsersController(UserService userService)
        {
            _userService = userService;
        }


        // Endpoint to get the current user's profile
        [HttpGet("profile")]
        public IActionResult GetUserProfile()
        {
            var username = User.Identity?.Name;
            var user = _userService.GetUserByUsername(username);

            return Ok(new
            {
                user.Username,
                user.FirstName,
                user.LastName,
                user.Email,
                user.Role
            });
        }

        [Authorize]
        // Endpoint to update the current user's profile
        [HttpPut("profile")]
        public IActionResult UpdateUserProfile([FromBody] User updatedUserInfo)
        {
            var username = User.Identity?.Name;
            var user = _userService.GetUserByUsername(username);

            user.FirstName = updatedUserInfo.FirstName;
            user.LastName = updatedUserInfo.LastName;
            user.Email = updatedUserInfo.Email;
            user.Role = updatedUserInfo.Role;

            _userService.UpdateUser(user);

            return Ok("Profile updated successfully.");
        }

        [Authorize]
        // Endpoint to change the user's password
        [HttpPut("change-password")]
        public IActionResult ChangePassword([FromBody] ChangePasswordRequest request)
        {
            var username = User.Identity?.Name;
            var user = _userService.GetUserByUsername(username);

            if (!_userService.VerifyPassword(request.OldPassword, user.Password))
                return BadRequest("Old password is incorrect.");

            _userService.ChangePassword(user, request.NewPassword);

            return Ok("Password changed successfully.");
        }



        // Helper class for change password request
        public class ChangePasswordRequest 
        {
            public string OldPassword { get; set; }
            public string NewPassword { get; set; }
        }


    }


}
