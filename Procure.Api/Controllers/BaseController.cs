global using Procure.Api.Controllers;
global using Procure.BLL.Interfaces;
global using Procure.Data.Entities;
global using Procure.Data.Models;
global using Procure.Api.Helpers;
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
        protected IApiResponse _apiResponse;
        protected MessageBuilder _messageBuilder;
        public BaseController(IConfiguration config, IMapper mapper)
        {
            _config = config;
            _mapper = mapper;
            _apiResponse = new ApiResponse();
        }
    }
}
