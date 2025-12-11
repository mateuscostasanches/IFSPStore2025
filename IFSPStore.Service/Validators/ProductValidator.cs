
using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{

    public class ProductValidator : AbstractValidator<Product>
    {

        #region Validation
        public ProductValidator() {

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Product Name is required!")
                .MaximumLength(100).WithMessage("Product Name has to be less than 100 caracters!");

            RuleFor(p => p.Price)
                .GreaterThan(0).WithMessage("Product Price has to be more than zero!");

           RuleFor(p => p.SalesUnit)
                .MaximumLength(10).WithMessage("Product Unit Sale can't be more than 10 caracters!");

            RuleFor(p => p.Category)
                .NotNull().WithMessage("Product Category is required!");

        }
        #endregion

    }

}
