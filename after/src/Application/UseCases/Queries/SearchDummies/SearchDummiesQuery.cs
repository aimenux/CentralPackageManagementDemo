using MediatR;

namespace CentralPackageManagementDemo.Application.UseCases.Queries.SearchDummies;

public sealed record SearchDummiesQuery(string Keyword) : IRequest<SearchDummiesQueryResponse>;