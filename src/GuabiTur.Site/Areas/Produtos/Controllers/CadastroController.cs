using Microsoft.AspNetCore.Mvc;

namespace GuabiTur.Site.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}