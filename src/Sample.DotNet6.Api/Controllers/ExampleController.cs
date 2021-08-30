using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Sample.DotNet6.Api.Services;

[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{
    [HttpGet("test")]
    public async Task<IResult> AutoAllocateAsync([FromQuery] bool? isHappy, [FromServices] IHelloService service)
    {
        if (isHappy is null)
            return Results.BadRequest();

        return Results.Ok(service.Hello((bool)isHappy));
    }
}
