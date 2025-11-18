using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() {

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome do cliente obrigatório!");
            RuleFor(c => c.Document)
                .NotEmpty().WithMessage("Documento do cliente obrigatório!");
            RuleFor(c => c.Address)
                .Length(10, 100).WithMessage("Endereço deve conter entre 10 e 100 caracteres");
           
        }
    }
}
