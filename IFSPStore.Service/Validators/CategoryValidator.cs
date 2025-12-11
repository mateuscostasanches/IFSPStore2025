
using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{

    public class CategoryValidator : AbstractValidator<Category>
    {

        #region Validation
        public CategoryValidator() {

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Name is required!");
        }
        #endregion 

    }

}
