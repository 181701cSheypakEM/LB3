using Sheypak_LB3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Sheypak_LB3.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult List()
        {
            return View(StaticDB.Products);
        }

        public IActionResult Details(int id)
        {
            return View(StaticDB.Products.FirstOrDefault(x=>x.Id == id));
        }
    }
}
