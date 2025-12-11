
using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{

    public class CustomerValidator : AbstractValidator<Customer>
    {

        #region Validation
        public CustomerValidator() {

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Customer Name is required!");

            RuleFor(c => c.Document)
                .NotEmpty().WithMessage("Customer Document is required!");

            RuleFor(c => c.Address)
                .NotEmpty().WithMessage("Customer Address is required!");

            RuleFor(c => c.District)
                .NotEmpty().WithMessage("Customer Addres is required!")
                .Length(10, 100).WithMessage("District has to be more than 10 and less than 100 caracters!");
           
        }
        #endregion 

    }

}
