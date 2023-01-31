using APIService.Controllers;
using APIService.IServices;
using APIService.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }
        [HttpPost(Name = "InsertPerson")]
        public int Post([FromBody] PersonItem personItem)
        {
            return _personService.InsertPerson(personItem);
        }

        [HttpGet(Name = "GetPersonItem")]
        public List<PersonItem> Get()
        {
            return _personService.GetPersonItem();
        }

        [HttpDelete(Name = "DeletePerson")]
        public void Delete([FromHeader] string userName, [FromHeader] string userPassword, [FromQuery] int id)
        {
            //var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
            //if (validCredentials == true)
            //{
                _personService.DeletePerson(id);
            //}
            //else
            //{
            //    throw new InvalidCredentialException();
            //}
        }

    }
}
