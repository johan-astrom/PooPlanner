using Microsoft.AspNetCore.Mvc;
using PooPlanner.Service.Services;
using PooPlanner.Shared.DTO;

namespace PooPlanner.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class MedicationController : ControllerBase
    {
        private IMedicationService _service;

        public MedicationController(IMedicationService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllMedications()
        {
            return Ok(_service.GetAllMedications());
        }

        [HttpGet("{id}")]
        public IActionResult GetMedicationById(long id)
        {
            return Ok(_service.GetMedicationById(id));
        }

        [HttpGet("/getByTimestamp")]
        public IActionResult GetMedicationByTimestamp(DateTime startTime, DateTime endTime){
            return Ok(_service.GetMedicationByTimestamp(startTime, endTime));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateMedication(MedicationPostDto medication)
        {
            var createdMedication = _service.CreateMedication(medication);
            if (createdMedication == null)
            {
                return BadRequest("Unable to create medication");
            }
            return CreatedAtAction(nameof(GetMedicationById), new { createdMedication.Id }, createdMedication);
        }


    }
}
