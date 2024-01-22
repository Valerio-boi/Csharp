using Database;
using ApiWeb.Model.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static FakeDataBase db = new FakeDataBase();

        [HttpGet("all")]
        public IActionResult GetAllData()
        {
            return Ok(db.Users);
        }

        [HttpGet]
        public IActionResult GetUser(int id)
        {
            User user = db.Users[id];
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {

            User user = db.Users[id];
            if (user == null)
            {
                return NotFound();
            }

            db.Users.Remove(user);

            return Ok("User eliminato con successo");
        }

        [HttpPost]
        public IActionResult addUser(UserRequest user) {
            Console.WriteLine("Inserisco lo user");

            db.AddUser(new User
            {
                UserName = user.UserName,
                Name = user.Name,
                Surname = user.Surname,
                Password = user.Password
            });

            return Ok("User inserito correttamente");
        }

    }
}
