using Microsoft.AspNetCore.Mvc;

namespace ASE.Controllers
{
    public class AssetTopologyController : Controller
    {
        // 靜態拓撲資料 (可替換為從後端資料庫抓取資料)
        public IActionResult Index()
        {
            var topologyData = new
            {
                nodes = new[]
                {
                    new { data = new { id = "1", label = "設備 1", type = "router" } },
                    new { data = new { id = "2", label = "設備 2", type = "switch" } },
                    new { data = new { id = "3", label = "設備 3", type = "server" } },
                    new { data = new { id = "4", label = "設備 4", type = "workstation" } },
                    new { data = new { id = "5", label = "設備 5", type = "firewall" } },
                    new { data = new { id = "6", label = "設備 6", type = "workstation" } }
                },
                        edges = new[]
                {
                    new { data = new { source = "1", target = "2" } }, // Router to Switch
                    new { data = new { source = "2", target = "3" } }, // Switch to Server
                    new { data = new { source = "2", target = "4" } }, // Switch to Workstation A
                    new { data = new { source = "1", target = "5" } }, // Router to Firewall
                    new { data = new { source = "5", target = "6" } }  // Firewall to Workstation B
                }
            };


            return View(topologyData);
        }

    }
}
