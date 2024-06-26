﻿using FluentValidation;

namespace CentralPackageManagementDemo.Application.UseCases.Queries.GetDummy;

public class GetDummyQueryValidator : AbstractValidator<GetDummyQuery>
{
    public GetDummyQueryValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty();
    }
}