using Business.Helpers;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapperTestController : ControllerBase
    {
        private readonly MapperService _mapperService;

        public MapperTestController(MapperService mapperService)
        {
            _mapperService = mapperService;
        }

        [HttpGet(nameof(DirectMap))]
        public IActionResult DirectMap()
        {
            return Ok(_mapperService.DirectMap(StaticValues.Instance.StudentList));
        }

        [HttpGet(nameof(SelectMap))]
        public IActionResult SelectMap()
        {
            return Ok(_mapperService.SelectMap(StaticValues.Instance.StudentList));
        }
    }
}
