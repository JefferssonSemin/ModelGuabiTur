using Microsoft.AspNetCore.Mvc;

namespace GuabiTur.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}