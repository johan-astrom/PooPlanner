using Microsoft.AspNetCore.Mvc;
using PooPlanner.Shared.DTO;
using PooPlanner.Service.Services;

namespace PooPlanner.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishesController : ControllerBase
    {
        private readonly IFoodService _service;
        public DishesController(IFoodService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllDishes()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetDishById(long id)
        {
            var dish = _service.GetById(id);
            return Ok(dish);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateDish(FoodPostDto dish)
        {
            var createdDish = _service.Create(dish);
            if (createdDish == null)
            {
                return BadRequest("Unable to create dish");
            }
            return CreatedAtAction(nameof(GetDishById), new { createdDish.Id}, createdDish);
        }
    }
}