using System.Threading.Tasks;
using Sample.DotNet6.Domain.Services;

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

