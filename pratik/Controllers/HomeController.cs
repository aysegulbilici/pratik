using Microsoft.AspNetCore.Mvc;
using pratik.Models;
using System.Diagnostics;

namespace pratik.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}