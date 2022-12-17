using BuzDolabiV3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BuzDolabiV3.Controllers
{
    public class TariflerController : Controller
    {
        private readonly ILogger<TariflerController> _logger;

        public TariflerController(ILogger<TariflerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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