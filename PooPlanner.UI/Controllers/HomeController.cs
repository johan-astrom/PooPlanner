using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PooPlanner.UI.Models;
using PooPlannerUI.Models;
using System.Diagnostics;

namespace PooPlannerUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Planner()
        {
            List<PlannerViewModel> viewModels = new();
            using var client = new HttpClient();
            using (var response = await client.GetAsync("https://localhost:7073/api/dishes"))
            {
                string reponseJson = await response.Content.ReadAsStringAsync();
                viewModels = JsonConvert.DeserializeObject<List<PlannerViewModel>>(reponseJson);
            }

            return View(viewModels);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}