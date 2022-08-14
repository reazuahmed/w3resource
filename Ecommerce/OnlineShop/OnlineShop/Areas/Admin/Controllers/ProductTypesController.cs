using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        private ApplicationDbContext _db;
        public ProductTypesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //var data = _db.ProductTypes.ToList();
            return View(_db.ProductTypes.ToList()); //It is sending a collection of ProductTypes{}.
            //সূতরাং, যখন আমি View() তে গিয়ে collection model receive করবো, তখন অবশ্যই সেটা collection type এর হতে হবে।।
        }
    }
}
