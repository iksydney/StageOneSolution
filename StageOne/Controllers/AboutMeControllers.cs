using ContractsAndImplementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StageOneAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutMeControllers : ControllerBase
    {
        private readonly IService _service;
        public AboutMeControllers(IService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var entity = await _service.GetAboutMe();
            return Ok(entity);
        }
    }
}
