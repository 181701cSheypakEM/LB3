using Sheypak_LB3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Sheypak_LB3.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Add(int productId)
        {
            return View(StaticDB.Products.FirstOrDefault(x=>x.Id == productId));
        }
    }
}
