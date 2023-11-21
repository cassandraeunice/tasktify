using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tasktify.Models;

namespace Tasktify.Controllers
{
    public class TasktifyController : Controller
    {
        private readonly ILogger<TasktifyController> _logger;

        public TasktifyController(ILogger<TasktifyController> logger)
        {
            _logger = logger;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult UserProfile()
        {
            return View();
        }
        
        public IActionResult Todo()
        {
            return View();
        }
        public IActionResult Categories()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        public IActionResult SignUpPage()
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