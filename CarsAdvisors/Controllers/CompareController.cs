using CarsAdvisors.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;

namespace CarsAdvisors.Controllers
{
    [Authorize]
    public class CompareController : Controller
    {
        Cars Context=new Cars();
        public IActionResult Insert(Compare newObj)
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            newObj.User_ID= userID;

            var count=Context.Compares.Where(c=>c.User_ID==userID).Count();
            if (count < 3)
            {
            Context.Compares.Add(newObj);
                Context.SaveChanges();
                TempData["Sucess"] = "success";
                var model=Context.Models.Where(m=>m.ID==newObj.Model_ID).FirstOrDefault();
                return PartialView("_CompareSucess", model);


            }
            else
            {
                TempData["Sucess"] = null;
                return PartialView("_CompareSucess");

            }
        }
        public IActionResult Compare()
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            var Cart = Context.Compares.Include(c=>c.Model).Where(c=>c.User_ID==userID).ToList();
            return View(Cart);
        }

        public IActionResult Delete(int id)
        {
            Compare oldcompare = Context.Compares.FirstOrDefault(d => d.CompareID == id);
            Context.Compares.Remove(oldcompare);
            Context.SaveChanges();
            return RedirectToAction("Compare");
        }
        public IActionResult Count()
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var count = Context.Compares.Where(c=>c.User_ID==userID).Count();
            if(count < 3)
            {
            return Ok(count+1);

            }
            else
            {
                return Ok(3);

            }
        }
    }
}
