using APIService.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IUsersService _userService;
        public UserController(ILogger<ProductController> logger, IUsersService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        [HttpPost(Name = "InsertUser")]
        public int Post([FromBody] UsersItem userItem)
        {
            return _userService.InsertUser(userItem);
        }
    }
}
