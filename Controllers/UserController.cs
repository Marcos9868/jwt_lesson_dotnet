using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static User user = new User
        {
            Id = 1,
            Username = "Jess",
            PasswordHash = "$2y$10$CdL4OgO3q2qNU4t/SoK.gODfrziyOkEAUL4nPIjmnR0nGlYaV4NPm"
        };

        [HttpGet("users"), Authorize()]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<User> ListUsers()
        {
            return user;
        }
    }
}