using CarsAdvisors.Models;
using CarsAdvisors.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace CarsAdvisors.Controllers
{
    [Authorize(Roles = "Admin")]

    public class MakerController : Controller
    {
         Cars Context=new Cars();

        public IHostingEnvironment Hosting { get; }

        public MakerController(IHostingEnvironment hosting)
        {
            Hosting = hosting;

        }
        public IActionResult Delete(int id)
        {

            Maker oldMaker = Context.Makers.FirstOrDefault(d => d.ID == id);
            Context.Makers.Remove(oldMaker);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();

            var Maker = Context.Makers.FirstOrDefault(d => d.ID == id);

            return View(Maker);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(int id, Maker newmaker, IFormFile File)
        {
            if (File != null)
            {
                string uploads = Path.Combine(Hosting.WebRootPath, "Images");
                string filename = File.FileName;
                string fullpath = Path.Combine(uploads, filename);
                File.CopyTo(new FileStream(fullpath, FileMode.Create));
                newmaker.MakerImage = filename;
            }

            if (ModelState.IsValid == true)
            {
                Maker oldMaker = Context.Makers.FirstOrDefault(d => d.ID == id);
                oldMaker.MakerName = newmaker.MakerName;
                oldMaker.MakerImage = newmaker.MakerImage;
                Context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View("Edit", newmaker);
        }
        public IActionResult Index()
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            ViewData["Make"] = Context.Makers.ToList();
            List<Maker> makers = Context.Makers.ToList();
            return View(makers);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(IFormFile File, Maker Newobj)
        {
            if (File != null)
            {
                string uploads = Path.Combine(Hosting.WebRootPath, "Images");
                string filename = File.FileName;
                string fullpath = Path.Combine(uploads, filename);
                File.CopyTo(new FileStream(fullpath, FileMode.Create));
                Newobj.MakerImage = filename;
            }

            if (ModelState.IsValid == true)
            {
                Context.Makers.Add(Newobj);
                 Context.SaveChanges();
                return RedirectToAction("index");
            }
            return View("New", Newobj);
        }
        public IActionResult New()
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            return View();
        }
    }
}
