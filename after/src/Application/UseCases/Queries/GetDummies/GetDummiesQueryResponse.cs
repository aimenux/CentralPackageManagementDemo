using CentralPackageManagementDemo.Domain.Models.Entities;

namespace CentralPackageManagementDemo.Application.UseCases.Queries.GetDummies;

public sealed record GetDummiesQueryResponse(ICollection<Dummy> Dummies);