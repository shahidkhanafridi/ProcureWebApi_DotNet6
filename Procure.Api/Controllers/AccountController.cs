using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Procure.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseController
    {
        public AccountController(IConfiguration config, IMapper mapper) : base(config, mapper)
        {

        }
    }
}
