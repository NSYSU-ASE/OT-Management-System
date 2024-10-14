using Microsoft.AspNetCore.Mvc;

namespace ASE.Controllers
{
    public class GlpiController : Controller
    {
        // GLPI 進入頁面
        public IActionResult Index()
        {
            return View();
        }

        // Embed GLPI
        public IActionResult Embed()
        {
            return View();
        }
    }
}
