using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using online_mart.Models;

namespace online_mart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ItemDbContext _db;
        public HomeController(ItemDbContext db)
        {
           _db = db;
        }
        public IActionResult HomePage()
        {
            var Items = _db.Items.ToList();
            return View(Items);
        }

        public async Task<IActionResult> MakeOrder(int id)
        {
            if (HttpContext.Session.GetString("UserName") == null || HttpContext.Session.GetString("Address") == null) 
            {
                return RedirectToAction("Login", "Account");
            }
            //Console.WriteLine("id=" + id);
            var orderdetails= await _db.Items.FindAsync(id);
            return RedirectToAction("OrderConformation","Order",orderdetails);     
        }

        public async Task<IActionResult> AddtoCart(int id)
        {
            if (HttpContext.Session.GetString("UserName") == null || HttpContext.Session.GetString("Address") == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var details = await _db.Items.FindAsync(id);
            Console.WriteLine("id=" + id);
            return RedirectToAction("AddItemToCart","Cart",details);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

    }
}
