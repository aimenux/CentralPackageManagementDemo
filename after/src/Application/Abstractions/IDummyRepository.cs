using CentralPackageManagementDemo.Domain.Models.Entities;
using CentralPackageManagementDemo.Domain.Models.ValueObjects;

namespace CentralPackageManagementDemo.Application.Abstractions;

public interface IDummyRepository
{
    Task<ICollection<Dummy>> GetDummiesAsync(CancellationToken cancellationToken);
    Task<ICollection<Dummy>> SearchDummiesAsync(string keyword, CancellationToken cancellationToken);
    Task<Dummy?> GetDummyByIdAsync(DummyId id, CancellationToken cancellationToken);
    Task<Dummy> AddDummyAsync(DummyName name, CancellationToken cancellationToken);
}