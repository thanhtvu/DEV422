using Microsoft.AspNetCore.Mvc;

namespace UserManagementAPI.Controllers
{

        [ApiController]
        [Route("api/[controller]")]

        public class UserController : ControllerBase
        {
            // list
            private static List<User> Users = new List<User>();

            [HttpGet]
            // get User
            public ActionResult<List<User>> GetUsers()
                {
            return Ok(Users);
                }

            [HttpPost]
            // add
            public ActionResult AddUser(User user)
            {
                user.Id = Users.Count + 1;
                Users.Add(user);
                return Ok("User added successfully");
            }

        // delete
        [HttpDelete("{id}")]
            public ActionResult DeleteUser(int id)
            {
                var user = Users.FirstOrDefault(x => x.Id == id);
                if(user == null )
                {
                    return NotFound("User not Found.");
                }
                Users.Remove(user);
                return Ok("User Removed Successfully.");
                {
                
                }
            }
        

        }




    
}
