using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // GET api/user - list all users
        private static List<User> Users = new List<User>();
        [HttpGet]
        public ActionResult<List<User>> GetUsers() 
        {
            return Ok(Users);
        }

        [HttpPost]
        // add a new user
        public ActionResult AddUser(User user)
        {
            user.Id = Users.Count + 1;
            Users.Add(user);
            return Ok("User added successfully");
        }

        // delete a user
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var user = Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound("User not found");
            }
            Users.Remove(user);
            return Ok("User deleted successfully");
        }
    }
}
