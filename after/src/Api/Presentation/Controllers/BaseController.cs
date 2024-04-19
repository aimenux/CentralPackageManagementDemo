using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace CentralPackageManagementDemo.Api.Presentation.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class BaseController : ControllerBase
{
    protected string ApiVersion => HttpContext.GetRequestedApiVersion()?.ToString() ?? "1";
}