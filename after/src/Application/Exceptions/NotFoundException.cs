using CentralPackageManagementDemo.Domain.Models.ValueObjects;

namespace CentralPackageManagementDemo.Application.Exceptions;

public sealed class NotFoundException : Exception
{
    private NotFoundException(string message) : base(message)
    {
    }

    public static NotFoundException DummyIsNotFound(DummyId dummyId)
    {
        return new NotFoundException($"Dummy ({dummyId.Value}) is not found.");
    }
}