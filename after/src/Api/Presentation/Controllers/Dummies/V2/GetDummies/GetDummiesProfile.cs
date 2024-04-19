using AutoMapper;
using CentralPackageManagementDemo.Application.UseCases.Queries.GetDummies;
using CentralPackageManagementDemo.Domain.Models.Entities;

namespace CentralPackageManagementDemo.Api.Presentation.Controllers.Dummies.V2.GetDummies;

public sealed class GetDummiesProfile : Profile
{
    public GetDummiesProfile()
    {
        CreateMap<GetDummiesRequest, GetDummiesQuery>();
        CreateMap<GetDummiesQueryResponse, GetDummiesResponse>();
        CreateMap<Dummy, GetDummyDto>()
            .ForCtorParam(nameof(GetDummyDto.Id), opt => opt.MapFrom(src => src.Id.Value))
            .ForCtorParam(nameof(GetDummyDto.Name), opt => opt.MapFrom(src => src.Name.Value));
    }
}