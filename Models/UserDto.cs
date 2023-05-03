using System.ComponentModel.DataAnnotations.Schema;

namespace asp.net_controller_api.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required AddressDto Address { get; set; }
    }
}
