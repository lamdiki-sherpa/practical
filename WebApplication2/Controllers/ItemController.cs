using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ItemController : Controller
    {
        private DatabaseContext _contxt;

        public ItemController(DatabaseContext context)
        {
            _contxt = context;
        }

        public IActionResult Index()
        {
            var items = _contxt.products.ToList(); //select *from products
            return View(items);
        }
         public IActionResult Tablecontent()
          {
              var item = _contxt.products.ToList();
              return View(item);
          }
      
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Item it)
        {
            if (ModelState.IsValid)
            {
                var i = new Item()
                {
                    Itemname = it.Itemname,
                    Price = it.Price,


                };
                _contxt.products.Add(i);//insert the data
                _contxt.SaveChanges();
                TempData["msg"] = "created";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Some error occured";
                return View();
            }

        }
        public IActionResult Remove(int id)
        {
            var it = _contxt.products.SingleOrDefault(i => i.Id == id);   //select * from products where id ='id
            _contxt.products.Remove(it);
            _contxt.SaveChanges();
            TempData["msg"] = "successfully removed";
            return RedirectToAction("Index");
        }
       
        public IActionResult Edit(int id)
        {
            var it = _contxt.products.SingleOrDefault(i => i.Id == id);
            return View(it);
        }
        [HttpPost]
        public IActionResult Edit(Item i)
        {
            if (ModelState.IsValid)
            {
                _contxt.products.Update(i);
                _contxt.SaveChanges();
                TempData["msg"] = "successfully updated";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Some error occured";
                return View();
            }
        }
        

    }
}
