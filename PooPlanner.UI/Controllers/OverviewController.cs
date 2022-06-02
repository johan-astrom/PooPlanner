using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PooPlanner.UI.Models;

namespace PooPlanner.UI.Controllers
{
    public class OverviewController : Controller
    {
        private readonly HttpClient _httpClient = new();
        private readonly string _url = "https://localhost:7073/api";

        public async Task<IActionResult> Index(OverviewViewModel viewModel)
        {
            viewModel.Stools = await GetStools();
            viewModel.Dishes = await GetDishes();   
            viewModel.Medications = await GetMedications();

            return View(viewModel);
        }

        private async Task<List<StoolModel>> GetStools()
        {
            var stoolEndpoint = _url + "/stool";
            var result = await _httpClient.GetAsync(stoolEndpoint);
            var jsonResult = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<StoolModel>>(jsonResult);
        }

        private async Task<List<DishModel>> GetDishes()
        {
            var dishEndpoint = _url + "/dishes";
            using var result = await _httpClient.GetAsync(dishEndpoint);
            var jsonResult = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<DishModel>>(jsonResult);
        }

        private async Task<List<MedicationModel>> GetMedications()
        {
            var medicationEndpoint = _url + "/medications";
            using var result = await _httpClient.GetAsync(medicationEndpoint);
            var jsonResult = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<MedicationModel>>(jsonResult);
        }   
    }
}
