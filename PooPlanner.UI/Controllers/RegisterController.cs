using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PooPlanner.UI.Models;

namespace PooPlanner.UI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly HttpClient _httpClient = new();
        private readonly string _url = "https://localhost:7073/api";

        public async Task<IActionResult> Index(RegisterViewModel viewModel)
        {
            var medicineEndpoint = _url + "/medicine";
            using var response = await _httpClient.GetAsync(medicineEndpoint);
            string responseJson = await response.Content.ReadAsStringAsync();
            viewModel.Medicines = JsonConvert.DeserializeObject<List<MedicineModel>>(responseJson);
            return View(viewModel);
        }

        [HttpGet]
        public async Task<JsonResult> GetMedicineById(long medicineId)
        {
            var endpoint = _url + "/medicine/" + medicineId;
            using var response = await _httpClient.GetAsync(endpoint);
            string responseJson = await response.Content.ReadAsStringAsync();
            
            return Json(responseJson);
        }  


        [HttpPost]
        public async Task<IActionResult> RegisterStool(RegisterViewModel viewModel)
        {
            var endpoint = _url + "/stool";
            await _httpClient.PostAsJsonAsync(endpoint, viewModel.Stool);
            return RedirectToAction("Index", viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterMedicine(RegisterViewModel viewModel)
        {
            var endpoint = _url + "/medicine";
            await _httpClient.PostAsJsonAsync(endpoint, viewModel.Medicine);
            return RedirectToAction("Index", viewModel);    
        }

        [HttpPost]
        public async Task<IActionResult> RegisterMedication(RegisterViewModel viewModel)
        {
            var endpoint = _url + "/medication";
            await _httpClient.PostAsJsonAsync(endpoint, viewModel.Medication);
            return RedirectToAction("Index", viewModel);
        }
    }
}
