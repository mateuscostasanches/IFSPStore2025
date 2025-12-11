
using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{

    public class UserValidator : AbstractValidator<User>
    {

        #region Validation
        public UserValidator() {

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("User Name is required!");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("User Email is required!")
                .EmailAddress().WithMessage("User Email is invalid!");

            RuleFor(c => c.Password)
                .NotEmpty().WithMessage("User Password can't be empty!")
                .MinimumLength(8).WithMessage("User Password had to be at least 8 characters!")
                .MaximumLength(16).WithMessage("User Password can't have more than 16 characters!")
                .Matches(@"[A-Z]+").WithMessage("User Password had to be at least one upper case!"); 
        }
        #endregion 

    }

}
