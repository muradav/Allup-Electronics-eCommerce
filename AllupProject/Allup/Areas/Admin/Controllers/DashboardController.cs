using Microsoft.AspNetCore.Mvc;

namespace Allup.Areas.AdminPanel.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
