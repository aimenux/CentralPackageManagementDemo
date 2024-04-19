using MediatR;

namespace CentralPackageManagementDemo.Application.UseCases.Commands.CreateDummy;

public record CreateDummyCommand(string Name) : IRequest<CreateDummyCommandResponse>;