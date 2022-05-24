using Microsoft.AspNetCore.Mvc;
using PooPlanner.Service.Services;
using PooPlanner.Shared.DTO;

namespace PooPlanner.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class StoolController : ControllerBase
    {
        private readonly IStoolService _service;

        public StoolController(IStoolService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllStools()
        {
            return Ok(_service.GetAllStools());
        }
        [HttpGet("{id}")]
        public IActionResult GetStoolById(long id)
        {
            return Ok(_service.GetStoolById(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateStool(StoolPostDto stool)
        {
            var createdStool = _service.CreateStool(stool);
            if (createdStool == null)
            {
                return BadRequest("Unable to create stool");
            }
            return CreatedAtAction(nameof(GetStoolById), new { createdStool.Id }, createdStool);
        }
    }
}
