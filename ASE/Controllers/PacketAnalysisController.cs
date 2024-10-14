using Microsoft.AspNetCore.Mvc;

namespace ASE.Controllers
{
    public class PacketAnalysisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
