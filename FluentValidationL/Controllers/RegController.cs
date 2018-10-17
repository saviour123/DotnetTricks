using FluentValidationL.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationL.Controllers
{
    [Route("[controller]/[action]")]
    public class RegController : Controller
    {
        [HttpGet]
        public IActionResult register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult register(RegisterViewModel model)
        {
            if(this.ModelState.IsValid)
            {
                ViewBag.SuccessMesage = "Great!";
            }
            return View();
        }
        
    }
}