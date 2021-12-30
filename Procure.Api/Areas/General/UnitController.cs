global using Procure.Api.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Procure.Api.Areas.General
{
    [Route("api/general/[controller]")]
    [ApiController]
    public class UnitController : BaseController
    {
        private readonly IUnitService _service;
        public UnitController(IConfiguration config, IMapper mapper, IUnitService service) : base(config, mapper)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult CreateUnit(UnitVM model)
        {
            try
            {
                var result = _service.CreateUnit(model);
                if (result == null)
                {
                    throw new Exception("Not found");
                }

                _apiResponse = ResponseHelper.Success(result, _messageBuilder.CreatedOrUpdated(model.Id, result.Id));
            }
            catch (Exception ex)
            {
                _apiResponse = ex.HandleEx(_mapper, ""); //_apiResponse = ResponseHelper.Error(ex.Message);
            }
            return Ok(_apiResponse);
        }

        [HttpGet("{code}")]
        public ActionResult<ApiResponse> GetUnit(string code)
        {
            try
            {
                UnitVM model = new() { UnitCode = code };
                var result = _service.GetUnit(model);
                if (result == null)
                {
                    throw new Exception("Not found");
                }

                _apiResponse = ResponseHelper.Success(result);
            }
            catch (Exception ex)
            {
                _apiResponse = ex.HandleEx(_mapper, "");//ResponseHelper.Error(ex.Message);
            }
            return Ok(_apiResponse);
        }
    }
}
