using Microsoft.AspNetCore.Mvc;
using PooPlanner.Service.Services;
using PooPlanner.Shared.DTO;

namespace PooPlanner.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineService _service;

        public MedicineController(IMedicineService medicineService)
        {
            _service = medicineService;
        }

        [HttpGet]   
        public IActionResult GetAllMedicines()
        {
            return Ok(_service.GetAllMedicines());
        }

        [HttpGet("{id}")]
        public IActionResult GetMedicineById(long id)
        {
            return Ok(_service.GetMedicineById(id));    
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateMedicine(MedicinePostDto medicine)
        {
            var createdMedicine = _service.CreateMedicine(medicine);
            if (createdMedicine == null)
            {
                return BadRequest("Unable to create medicine.");
            }
            return CreatedAtAction(nameof(GetMedicineById), new { createdMedicine.Id}, createdMedicine);
        }
    }
}
