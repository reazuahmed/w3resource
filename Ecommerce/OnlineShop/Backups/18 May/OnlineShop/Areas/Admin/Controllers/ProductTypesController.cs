using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Data;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")] //It means - "Admin" is the areaName. It initializes a new AreaAttribute instance. 'areaName' is the area containing the controller or action.
    public class ProductTypesController : Controller
    {
        ApplicationDbContext _db;   //I have just created a reference (instance) of ApplicationDbContext.
        //আমি চাই, যতগুলা Products এর Type আছে, সবগুলির Collection{} আমি চাই।
        public ProductTypesController(ApplicationDbContext db)  //Contructor()
        {
            //Whenever this Constructor() will be called, the added reference (parameter within the Constructor) will be passed to the "_db" reference
            //যখন আমার এই Constructor() called হবে, তখনই একটা যেই আমার parameter আকারে একটা reference added হবে, সেটাকে আমি "ApplicationDbContext" এ (_db)
            //বের করে দিবো। That's it.
            _db = db;
        }
        public IActionResult Index(ApplicationDbContext db)    //Reaz: This is the ActionMethod named Index(). This is the default action method.
        {
            //This method will return the collection{} of as many ProductTypes as I will add.
            //(যতগুলি Product এর Type add করবো, সেই Product এর একটা collection{} আমাকে দিবে।
            return View(_db.ProductTypes.ToList()); //আমারজ যতগুলি ProductType আছে, আমি সেগুলকে List{} আকারে দেখতে চাই।
            //একটা View() generate করবো, যেখানে সেই data গুলি দেখতে পাবো।।
            //আমি এখানে যেই data pass করছি parameter হিসেবে, সেটা ছিলো List of ProductTypes. সেই type এর একটা object পাঠাচ্ছি parameter এ।
            //সূতরাং, যখন আমি View() generate করবো, same type এর List সেখানে (View) receive করবো।
            
            /*or
            var data = _db.ProductTypes.ToList();
            return View(data);
            */
        }
    }

    //return View();
}


//Start : https://www.youtube.com/watch?v=HsT3ZRXs5Fo&list=PLqCbg_KAOnCdRm3FI1EvndnsNNWz_1A5c&index=9
// 4:20 Min