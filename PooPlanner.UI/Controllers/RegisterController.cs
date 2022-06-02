using Microsoft.AspNetCore.Mvc;
using PooPlanner.UI.Models;

namespace PooPlanner.UI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly HttpClient _httpClient = new();
        private readonly string _url = "https://localhost:7073/api";
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterStool(RegisterViewModel viewModel)
        {
            var stool = viewModel.Stool;
            var endpoint = _url + "/stool";
            await _httpClient.PostAsJsonAsync(endpoint, viewModel.Stool);
            return View("Index", viewModel);
        }
    }
}
