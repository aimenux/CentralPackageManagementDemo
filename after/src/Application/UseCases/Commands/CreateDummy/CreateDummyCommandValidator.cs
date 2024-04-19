using FluentValidation;

namespace CentralPackageManagementDemo.Application.UseCases.Commands.CreateDummy;

public class CreateDummyCommandValidator : AbstractValidator<CreateDummyCommand>
{
    public CreateDummyCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty();
    }
}