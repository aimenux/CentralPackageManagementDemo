﻿using CentralPackageManagementDemo.Application.Exceptions;
using FluentValidation;
using MediatR;

namespace CentralPackageManagementDemo.Application.Behaviours;

public sealed class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators ?? throw new ArgumentNullException(nameof(validators));
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var context = new ValidationContext<TRequest>(request);
        
        var tasks = _validators
            .Select(x => x.ValidateAsync(context, cancellationToken))
            .ToList();
        var validationResults = await Task.WhenAll(tasks);
        var failures = validationResults
            .Where(x => x.Errors.Any())
            .SelectMany(x => x.Errors)
            .ToList();
        
        if (failures.Any())
        {
            throw new NotValidException(failures);
        }
        
        return await next();
    }
}