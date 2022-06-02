using Microsoft.AspNetCore.Mvc;

namespace PooPlanner.UI.Models
{
    public class OverviewViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
