using CarsAdvisors.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace CarsAdvisors.Controllers
{
        [Authorize(Roles = "Admin")]
    public class ImageController : Controller
    {

        private readonly IHostingEnvironment hosting;
        Cars Context = new Cars();

            public ImageController(IHostingEnvironment hosting)
            {

                this.hosting = hosting;
            }
            public IActionResult New(int id)
            {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewData["count"] = Context.Compares.Where(c => c.User_ID == userID).Count();
            var ModelID = Context.Models.FirstOrDefault(p => p.ID == id);
                return View(ModelID);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Insert(IFormFile File, Image Newobj)
            {
                if (File != null)
                {
                    string uploads = Path.Combine(hosting.WebRootPath, "Images");
                    string filename = File.FileName;
                    string fullpath = Path.Combine(uploads, filename);
                    File.CopyTo(new FileStream(fullpath, FileMode.Create));
                    Newobj.ImageName = filename;
                }

                if (ModelState.IsValid == true)
                {
                    Context.Images.Add(Newobj);
                Context.SaveChanges();
                return Redirect($"http://localhost:63964/Model/Details/{Newobj.Model_ID}");

            }
            return View("New", Newobj);
            }
     }
}

