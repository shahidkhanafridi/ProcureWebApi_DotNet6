global using Procure.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Procure.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly IConfiguration _config;
        protected readonly IMapper _mapper;
        public BaseController(IConfiguration config, IMapper mapper)
        {
            _config = config;
            _mapper = mapper;
        }
    }
}
