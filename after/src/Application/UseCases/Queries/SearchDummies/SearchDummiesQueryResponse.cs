using CentralPackageManagementDemo.Domain.Models.Entities;

namespace CentralPackageManagementDemo.Application.UseCases.Queries.SearchDummies;

public sealed record SearchDummiesQueryResponse(ICollection<Dummy> Dummies);