using asp.net_controller_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_controller_api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger) 
        {
            _logger = logger;
        }

        [HttpGet]
        public JsonResult GetUsers()
        {
            return new JsonResult(UserDataStore.Current.users);
        }

        [HttpGet("{id}", Name ="GetUser")]
        public JsonResult GetUser(int id)
        {
            return new JsonResult(UserDataStore.Current.users.FirstOrDefault(user => user.Id == id));
        }

        [HttpPost]
        public ActionResult<UserDto> CreateUser(string firstName, string lastName, DateTime dateOfBirth, string addressLine1, string addressLine2, string suburb, string city, string country, string postCode)
        {
            var user = new UserDto()
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Address = new AddressDto()
                {
                    Addressline1 = addressLine1,
                    Addressline2 = addressLine2,
                    Suburb = suburb,
                    City = city,
                    Country = country,
                    PostCode = postCode,
                }
            };

             UserDataStore.Current.users.Add(user);

            return CreatedAtRoute("GetUser", new { user.Id }, user);
        }
    }
}
