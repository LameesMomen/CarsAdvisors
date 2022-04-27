using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CarsAdvisors.Controllers
{
    [Authorize(Roles = "Admin")]

    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        public RoleController(RoleManager<IdentityRole> _roleManager)
        {
            roleManager = _roleManager;
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> New(string RoleName)
        {
            if (RoleName != null)
            {
                IdentityRole role = new IdentityRole(RoleName);
                IdentityResult result = await roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return Redirect("/Home/Index");
                }
                else
                {
                    TempData["msg"] = result.Errors.FirstOrDefault().Description;

                }
            }
            ViewData["RoleName"] = RoleName;
            return View();
        }
    }
}
