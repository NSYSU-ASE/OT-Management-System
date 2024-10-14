using ASE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // �����@�Ǳq��Ʈw������겣�ƾ�
            var assetData = new List<int> { 10, 20, 30 };  // �겣���� A, B, C ���ƶq
            ViewBag.AssetData = assetData;  // �q�L ViewBag �ǻ��ƾڨ����
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
