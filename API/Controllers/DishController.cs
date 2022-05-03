using Microsoft.AspNetCore.Mvc;
using Modules.Food.DTO;
using Modules.Food.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    internal class DishesController : ControllerBase
    {
        private readonly IFoodService _service;
        public DishesController(IFoodService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetDishById(long id)
        {
            var dish = _service.GetById(id);
            return Ok(dish);
        }
    }
}
