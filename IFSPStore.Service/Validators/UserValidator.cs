using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator() {

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome do usuário obrigatório!");
            RuleFor(c => c.Email)
                .EmailAddress().WithMessage("Email do usuário inválido!");
            RuleFor(c => c.Password)
                .NotEmpty().WithMessage("Sua senha não pode ser vazia")
                .MinimumLength(8).WithMessage("Sua senha tem que ter pelo menos 8 caracteres")
                .MaximumLength(16).WithMessage("Sua senha não pode ter mais de 16 caracteres")
                .Matches(@"[A-Z]+").WithMessage("Sua senha deve ter pelo menos uma letra maiúscula"); 
        }
    }
}
