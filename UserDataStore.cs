using asp.net_controller_api.Models;

namespace asp.net_controller_api
{
    public class UserDataStore
    {
        public List<UserDto> users { get; set; }

        public static UserDataStore Current { get; } = new UserDataStore();

        public UserDataStore() 
        {
            users = new List<UserDto>()
            {
                new UserDto()
                {
                    Id=1,
                    FirstName="Keri",
                    LastName="van der Westhuizen",
                    DateOfBirth = new DateTime(1977, 1, 1),
                    Address = new AddressDto {
                    Addressline1 = "Someplace",
                    Addressline2 = "1 main street",
                    Suburb = "Avalon",
                    City = "Wellington",
                    Country = "New Zealand",
                    PostCode = "6001",
                    }
                },
                new UserDto()
                {
                    Id=2,
                    FirstName="Grant",
                    LastName="van der Westhuizen",
                    DateOfBirth = new DateTime(1977, 1, 1),
                    Address = new AddressDto {
                    Addressline1 = "Someplace",
                    Addressline2 = "1 main street",
                    Suburb = "Avalon",
                    City = "Wellington",
                    Country = "New Zealand",
                    PostCode = "6001",
                    }
                }
            };      
        }
    }
}
