using Microsoft.AspNetCore.Mvc;
using PooPlanner.Service.Services;

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


    }
}
