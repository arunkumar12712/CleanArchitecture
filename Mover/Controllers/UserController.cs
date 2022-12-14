using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mover.Application;
using Mover.Domain;

namespace Mover.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            var response =_service.GetAllUsers();
            return Ok(response);
        }

        [HttpPost]
        public ActionResult<User> PostUser(User user)
        {
            var User = _service.CreateUser(user);
            return Ok(User);
        }
    }
}
