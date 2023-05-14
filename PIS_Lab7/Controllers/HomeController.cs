using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace PIS_Lab7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}