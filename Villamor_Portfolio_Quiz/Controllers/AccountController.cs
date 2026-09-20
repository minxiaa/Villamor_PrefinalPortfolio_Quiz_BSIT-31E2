using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Villamor_Portfolio_Quiz.Controllers
{
    public class AccountController : Controller
    {


        [HttpGet]
        public IActionResult Login()
        {
            return View("~/Views/Auth/Login.cshtml");
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "MyShayla" && password == "Veryx3strongpassword")
            {
                HttpContext.Session.SetString("Username", username);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid username or password.";
            return View("~/Views/Auth/Login.cshtml");
        }
    }
}
    

