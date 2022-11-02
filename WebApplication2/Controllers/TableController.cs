using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /* public IActionResult Tablecontent()
         {
             return View();
         }
        */
        public IActionResult Add(int id)
        {

            return View();
        }
    }
}
