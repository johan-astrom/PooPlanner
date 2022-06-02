using Microsoft.AspNetCore.Mvc;

namespace PooPlanner.UI.Controllers
{
    public class OverviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
