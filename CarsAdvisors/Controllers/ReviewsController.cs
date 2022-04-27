using CarsAdvisors.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace CarsAdvisors.Controllers
{
    [Authorize(Roles = "Admin")]

    public class ReviewsController : Controller
    {
        Cars Context=new Cars();
        public IActionResult Index()
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            var Reviews = Context.News_Reviews.ToList();
            return View(Reviews);
        }
        public IActionResult New()
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(News_Reviews Newobj)
        {
            
            if (ModelState.IsValid == true)
            {
                Context.News_Reviews.Add(Newobj);
                Context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View("New", Newobj);
        }
        public IActionResult Delete(int id)
        {

            News_Reviews old = Context.News_Reviews.FirstOrDefault(d => d.ID == id);
            Context.News_Reviews.Remove(old);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

