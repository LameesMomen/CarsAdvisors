using CarsAdvisors.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarsAdvisors.Controllers
{
    [Authorize]

    public class HomeController : Controller
    {
        Cars Context=new Cars();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Model=Context.Models.OrderByDescending(m=>m.ID).Where(m=>m.Year==System.DateTime.Now.Year).Take(9).ToList();
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            ViewData["Review"] = Context.News_Reviews.OrderByDescending(r=>r.ID).Take(4).ToList();

            return View(Model);
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
