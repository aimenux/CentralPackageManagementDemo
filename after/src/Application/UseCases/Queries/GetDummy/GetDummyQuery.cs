using MediatR;

namespace CentralPackageManagementDemo.Application.UseCases.Queries.GetDummy;

public sealed record GetDummyQuery(string Id) : IRequest<GetDummyQueryResponse>;