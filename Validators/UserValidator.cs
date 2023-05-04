using asp.net_controller_api.Models;
using FluentValidation;

namespace asp.net_controller_api.validators
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(u => u.Id)
                .NotEmpty();               
            RuleFor( u => u.FirstName)  
                .NotEmpty()
                .WithMessage("The first name field is required");
            RuleFor(u => u.LastName)
                .NotEmpty().WithMessage("The last name field is required")
                .MinimumLength(1).WithMessage("The last name must be greater than 1 character")
                .MaximumLength(50).WithMessage("The last name must be 50 characters or less");
            RuleFor( u => u.DateOfBirth)
                .NotEmpty().WithMessage("The date of birth field is required")
                .Must(date => date < DateTime.Today).WithMessage("The date of birth must be in the past."); 
/*            RuleFor(u => u.Address)
                .NotEmpty()
                .WithMessage("The address is required");*/
            RuleFor(u => u.Address.Addressline1)
                .NotEmpty().WithMessage("The first line of address is required")
                .MinimumLength(5).WithMessage("The last name must be greater than  character")
                .MaximumLength(20).WithMessage("The last name must be 20 characters or less");
            RuleFor(u => u.Address.Suburb)  
                .NotEmpty().WithMessage("The suburb is required")
                .MinimumLength(5).WithMessage("The last name must be greater than  character")
                .MaximumLength(20).WithMessage("The last name must be 20 characters or less");
            RuleFor(u => u.Address.City)
                .NotEmpty().WithMessage("The city is required")
                .MinimumLength(5).WithMessage("The last name must be greater than  character")
                .MaximumLength(20).WithMessage("The last name must be 20 characters or less");
            RuleFor(u => u.Address.Country)
                .NotEmpty().WithMessage("The country is required")
                .MinimumLength(5).WithMessage("The last name must be greater than  character")
                .MaximumLength(20).WithMessage("The last name must be 20 characters or less");
            RuleFor(u => u.Address.PostCode)
                .NotEmpty().WithMessage("The postcode is required")
                .MinimumLength(5).WithMessage("The last name must be greater than  character")
                .MaximumLength(20).WithMessage("The last name must be 20 characters or less");
        }
    }
}
