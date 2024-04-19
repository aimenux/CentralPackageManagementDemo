using FluentValidation;

namespace CentralPackageManagementDemo.Application.UseCases.Queries.SearchDummies;

public sealed class SearchDummiesQueryValidator : AbstractValidator<SearchDummiesQuery>
{
    public SearchDummiesQueryValidator()
    {
        RuleFor(x => x.Keyword)
            .NotEmpty();
    }
}