
using FluentValidation;
using IFSPStore.Domain.Entities;
    
namespace IFSPStore.Service.Validators
{

    public class CityValidator : AbstractValidator<City>
    {

        #region validation 
        public CityValidator() {

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("City is required!");

            RuleFor(c => c.State)
                .NotEmpty().WithMessage("State is required!")
                .Length(2).WithMessage("State has to be 2 letters!");


        }
        #endregion
        
    }

}
