﻿using AutoMapper;
using CentralPackageManagementDemo.Application.UseCases.Commands.CreateDummy;

namespace CentralPackageManagementDemo.Api.Presentation.Controllers.Dummies.V1.CreateDummy;

public sealed class CreateDummyProfile : Profile
{
    public CreateDummyProfile()
    {
        CreateMap<CreateDummyRequest, CreateDummyCommand>();
        CreateMap<CreateDummyCommandResponse, CreateDummyResponse>()
            .ForCtorParam(nameof(CreateDummyResponse.Id), opt => opt.MapFrom(src => src.Dummy.Id.Value))
            .ForCtorParam(nameof(CreateDummyResponse.Name), opt => opt.MapFrom(src => src.Dummy.Name.Value));
    }
}