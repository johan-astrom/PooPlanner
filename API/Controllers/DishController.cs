﻿using Microsoft.AspNetCore.Mvc;
using PooPlanner.Shared.Services;

namespace PooPlanner.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    internal class DishesController : ControllerBase
    {
        private readonly IFoodService _service;
        public DishesController(IFoodService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetDishById()
        {
            var dish = _service.GetById(9);
            return Ok(dish);
        }
    }
}
