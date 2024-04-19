using MediatR;

namespace CentralPackageManagementDemo.Application.UseCases.Queries.GetDummies;

public sealed record GetDummiesQuery : IRequest<GetDummiesQueryResponse>;