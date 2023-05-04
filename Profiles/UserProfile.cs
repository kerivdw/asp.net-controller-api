using AutoMapper;

namespace asp.net_controller_api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<Entities.User, Models.UserDto>().ForMember(dest => dest.Address, opts => opts.MapFrom(src => src.Address)).ReverseMap();
            CreateMap<Entities.Address, Models.AddressDto>();
        }
    }
}
