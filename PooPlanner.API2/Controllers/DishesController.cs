using Microsoft.AspNetCore.Mvc;
using PooPlanner.Shared.DTO;
using PooPlanner.Shared.Services;

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
        [HttpGet("{id}")]
        public IActionResult GetDishById(long id)
        {
            var dish = _service.GetById(id);
            return Ok(dish);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateDish(FoodDto dish)
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