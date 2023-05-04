using asp.net_controller_api.Models;
using asp.net_controller_api.Services;
using asp.net_controller_api.validators;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace asp.net_controller_api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        private readonly UserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(ILogger<UsersController> logger, UserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            var usersEntities = await _userRepository.GetUsersAsync();                       

            if (usersEntities == null)
            {
                return NoContent();
            }

            return Ok(_mapper.Map<IEnumerable<UserDto>>(usersEntities));
        }

        [HttpGet("{id}", Name = "GetUser")]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            var userEntity = await _userRepository.GetUserAsync(id);
            
            if (userEntity == null)
            {
                return NoContent();
            }
            return Ok(_mapper.Map<UserDto>(userEntity));  
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> PostUser(string firstName, string lastName, DateTime dateOfBirth, string addressLine1, string addressLine2, string suburb, string city, string country, string postCode)
        {
            var user = new Entities.User()
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Address = new Entities.Address()
                {
                    Addressline1 = addressLine1,
                    Addressline2 = addressLine2,
                    Suburb = suburb,
                    City = city,
                    Country = country,
                    PostCode = postCode,
                }
            };

            var validator = new UserValidator();
            var validationResult = validator.Validate(_mapper.Map<UserDto>(user));
            if (!validationResult.IsValid)
            {
                _logger.LogError("User failed validation: ", validationResult.Errors);
                return BadRequest(validationResult);
            }

            var userEntity = await _userRepository.CreateUserAsync(user);
            if (userEntity == null)
            {
                _logger.LogCritical("User could not be saved", userEntity);
                return StatusCode(500);
            }

            return CreatedAtRoute("GetUser", new { user.Id }, _mapper.Map<UserDto>(userEntity));
        }
    }
}
