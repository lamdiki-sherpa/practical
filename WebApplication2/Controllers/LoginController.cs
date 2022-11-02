using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
      

        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }


    }
    
}
