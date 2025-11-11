//using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
//using Omsyn.Models;

namespace Omsyn.Controllers
{

    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
