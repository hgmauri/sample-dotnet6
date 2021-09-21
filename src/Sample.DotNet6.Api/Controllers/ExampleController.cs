using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Sample.DotNet6.Domain.Services;
using Sample.DotNet6.Api.Core.Extensions;

namespace Sample.DotNet6.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        private readonly IHelloService _helloService;

        public ExampleController(IHelloService helloService) => _helloService = helloService;

        [HttpGet("test")]
        public async Task<ActionResult<bool>> AutoAllocateAsync([FromQuery] bool? isHappy) =>
            await ExecuteAsync<ActionResult<bool>>(async () =>
            {
                if (isHappy is null)
                    return BadRequest();

                return Ok(_helloService.Hello((bool)isHappy));
            });
    }
}

