using BasicAuthService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicAuthService.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        List<User> _users = new List<User>();
        public UsersController()
        {
            for (int i = 1; i <= 6; i++)
            {
                _users.Add(new User()
                {
                    userID = i,
                    name = "stu" + i,
                    Roll = "100" + i
                });

            }
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _users;
        }
    }
}

    

      
