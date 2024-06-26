﻿using CentralPackageManagementDemo.Application.Abstractions;
using CentralPackageManagementDemo.Application.Exceptions;
using CentralPackageManagementDemo.Domain.Models.ValueObjects;
using MediatR;

namespace CentralPackageManagementDemo.Application.UseCases.Queries.GetDummy;

public class GetDummyQueryHandler : IRequestHandler<GetDummyQuery, GetDummyQueryResponse>
{
    private readonly IDummyRepository _dummyRepository;

    public GetDummyQueryHandler(IDummyRepository dummyRepository)
    {
        _dummyRepository = dummyRepository;
    }

    public async Task<GetDummyQueryResponse> Handle(GetDummyQuery query, CancellationToken cancellationToken)
    {
        var dummyId = new DummyId(query.Id);
        var dummy = await _dummyRepository.GetDummyByIdAsync(dummyId, cancellationToken);
        if (dummy is null)
        {
            throw NotFoundException.DummyIsNotFound(dummyId);
        }
        
        var queryResponse = new GetDummyQueryResponse(dummy);
        return queryResponse;
    }
}