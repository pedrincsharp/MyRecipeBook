using FluentValidation;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Exceptions;

namespace MyRecipeBook.Application.UseCases.User.Register;
public class RegisterUserValidator : AbstractValidator<RegisterUserRequest>
{
    public RegisterUserValidator()
    {
        RuleFor(user => user.name)
            .NotEmpty()
            .WithMessage(ResourceMessagesException.NAME_EMPTY);

        RuleFor(user => user.email)
            .NotEmpty()
            .WithMessage(ResourceMessagesException.EMAIL_EMPTY)
            .EmailAddress()
            .WithMessage(ResourceMessagesException.EMAIL_INVALID);

        RuleFor(user => user.password)
            .NotEmpty()
            .WithMessage(ResourceMessagesException.PASSWORD_EMPTY)
            .MinimumLength(6)
            .WithMessage(ResourceMessagesException.PASSWORD_EMPTY);
    }
}
