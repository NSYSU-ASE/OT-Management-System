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
            // 模擬一些從資料庫獲取的資產數據
            var assetData = new List<int> { 10, 20, 30 };  // 資產類型 A, B, C 的數量
            ViewBag.AssetData = assetData;  // 通過 ViewBag 傳遞數據到視圖
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
