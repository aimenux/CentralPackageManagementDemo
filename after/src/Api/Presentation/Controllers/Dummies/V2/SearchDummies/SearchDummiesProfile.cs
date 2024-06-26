﻿using AutoMapper;
using CentralPackageManagementDemo.Application.UseCases.Queries.SearchDummies;
using CentralPackageManagementDemo.Domain.Models.Entities;

namespace CentralPackageManagementDemo.Api.Presentation.Controllers.Dummies.V2.SearchDummies;

public sealed class SearchDummiesProfile : Profile
{
    public SearchDummiesProfile()
    {
        CreateMap<SearchDummiesRequest, SearchDummiesQuery>();
        CreateMap<SearchDummiesQueryResponse, SearchDummiesResponse>();
        CreateMap<Dummy, SearchDummyDto>()
            .ForCtorParam(nameof(SearchDummyDto.Id), opt => opt.MapFrom(src => src.Id.Value))
            .ForCtorParam(nameof(SearchDummyDto.Name), opt => opt.MapFrom(src => src.Name.Value));
    }
}