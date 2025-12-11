
using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{

    public class SaleValidator : AbstractValidator<Sale>
    {

        #region Validation
        public SaleValidator()
        {
            RuleFor(sale => sale.Customer)
                .NotNull().WithMessage("Client is required!");

            RuleFor(sale => sale.SaleItems)
                .NotNull().WithMessage("Sale has to contain itens!")
                .Must(items => items != null && items.Count > 0)
                .WithMessage("Sale has to contain at least one item!");
        }
        #endregion 

    }

    public class SaleItemValidator : AbstractValidator<SaleItem>
    {

        #region Validation
        public SaleItemValidator()
        {
            RuleFor(item => item.Product)
                .NotNull().WithMessage("Product is required!");

            RuleFor(item => item.Quantity)
                .GreaterThan(0).WithMessage("Quantity has to be more than zero!");

            RuleFor(item => item.UnitPrice)
                .GreaterThan(0).WithMessage("Unit Price has to be more than zero!");

            RuleFor(item => item.TotalPrice)
                .GreaterThan(0).WithMessage("Total Price has to be more than zero!");
        }
        #endregion 

    }

}
