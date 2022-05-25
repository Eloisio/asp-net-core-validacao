using FluentValidation;
using TWValidacao.Models;

namespace TWValidacao.Validators;

public class CreateUserValidator : AbstractValidator<CreateUserViewModel>
{
    public CreateUserValidator()
    {
        RuleFor(user => user.FirstName)
            .NotNull().WithMessage("é um campo obrigatorio")
            .NotEmpty()
            .MinimumLength(3).WithMessage("deve ter pelo menos 3 caracteres")
            .MaximumLength(100);

        RuleFor(user => user.LastName)
            .NotNull()
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(100);

        RuleFor(user => user.Email)
            .NotNull()
            .NotEmpty()
            .MaximumLength(255)
            .EmailAddress();

        RuleFor(user => user.BirthDate)
            .NotNull()
            .NotEmpty()
            .AgeBetween(100, 18).WithMessage("deve ter entre 18 e 100 anos");

        RuleFor(user => user.PhoneNumber)
            .NotNull()
            .NotEmpty()
            .Matches("\\([0-9]{2}\\) [0-9]{1} [0-9]{4}-[0-9]{4}");

        RuleFor(user => user.ProfilePicture)
            .NotNull()
            .NotEmpty()
            .MaximumLength(255);

        RuleFor(user => user.Password)
            .NotNull()
            .NotEmpty()
            .MaximumLength(255);

        RuleFor(user => user.PasswordConfirmation)
            .NotNull()
            .NotEmpty()
            .MaximumLength(255)
            .Must((user, passwordConfirmation) => string.Equals(passwordConfirmation, user.Password));
    }
}