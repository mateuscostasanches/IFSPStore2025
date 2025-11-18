using FluentValidation;
using IFSPStore.Domain.Entities;
    
namespace IFSPStore.Service.Validators
{
    public class CityValidator : AbstractValidator<City>
    {

        public CityValidator() {

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome da cidade obrigatório");
            RuleFor(c => c.State)
                .NotEmpty().WithMessage("Nome do estado obrigatório")
                .Length(2).WithMessage("O estado deve conter 2 caracteres");


        }
    }
}
