using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator() {

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("nome é obrigatório!");
        }
    }
}
