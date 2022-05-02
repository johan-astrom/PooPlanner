using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Food.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    internal class DishesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllDishesAsync()
        {
            return Ok();
        }
    }
}
