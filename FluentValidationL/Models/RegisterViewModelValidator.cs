using FluentValidation;

namespace FluentValidationL.Models
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator ()
        {
            RuleFor(reg => reg.FirstName).NotEmpty().Length(4, 50);
            RuleFor(reg => reg.LastName).NotEmpty().NotNull();
            RuleFor(reg => reg.Email).EmailAddress().NotEmpty().NotNull();
        }
    }
}