using AutoMapper;
using CentralPackageManagementDemo.Api.Presentation.Controllers.Dummies.V2.SearchDummies;
using CentralPackageManagementDemo.Application.UseCases.Queries.SearchDummies;
using CentralPackageManagementDemo.UnitTests.Helpers;

namespace CentralPackageManagementDemo.UnitTests;

public class SearchDummiesTests
{
    private static readonly IFixture Fixture = new Fixture();
    
    private static readonly IMapper Mapper = new MapperBuilder()
        .WithProfile<SearchDummiesProfile>()
        .Build();
    
    [Fact]
    public void Should_Map_SearchDummiesRequest_To_SearchDummiesQuery()
    {
        // arrange
        var request = Fixture.Create<SearchDummiesRequest>();

        // act
        var query = Mapper.Map<SearchDummiesQuery>(request);

        // assert
        query.Should().NotBeNull();
        query.Keyword.Should().Be(request.Keyword);
    }
    
    [Fact]
    public void Should_Map_SearchDummiesQueryResponse_To_SearchDummiesResponse()
    {
        // arrange
        var queryResponse = Fixture.Create<SearchDummiesQueryResponse>();

        // act
        var response = Mapper.Map<SearchDummiesResponse>(queryResponse);

        // assert
        response.Should().NotBeNull();
        response.Dummies.Should().NotBeNullOrEmpty();
        response.Dummies.Should().HaveCount(queryResponse.Dummies.Count);
    }
}