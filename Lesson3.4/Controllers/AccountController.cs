using Lesson3._4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson3._4.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (model.Username == "admin" && model.Password == "123")
            {
                ViewData["Message"] = "Login success";
                return View();
            }
            else
            {
                ViewData["Message"] = "Login failed";
                return View();
            }
        }
    }
}
