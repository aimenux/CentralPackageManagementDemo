using FluentValidation;

namespace CentralPackageManagementDemo.Application.UseCases.Queries.GetDummies;

public sealed class GetDummiesQueryValidator : AbstractValidator<GetDummiesQuery>
{
    public GetDummiesQueryValidator()
    {
    }
}