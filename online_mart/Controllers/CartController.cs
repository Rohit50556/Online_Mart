using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using online_mart.Models;
using Microsoft.AspNetCore.Http;

namespace online_mart.Controllers
{
    public class CartController : Controller
    {
        private readonly CartDbContext _Db;

        public CartController(CartDbContext cartDb)
        {
            _Db = cartDb;
        }

        public async Task<IActionResult> AddItemToCart(CartClass obj)
        {
            obj.User = HttpContext.Session.GetString("UserName");
            _Db.Add(obj);
            await _Db.SaveChangesAsync();
            return RedirectToAction("CartItem");
        }

        public IActionResult CartItem()
        {
            
            if (HttpContext.Session.GetString("UserName") == null || HttpContext.Session.GetString("Address") == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var details=_Db.Cart.Where(data => data.User.Contains(HttpContext.Session.GetString("UserName"))).ToList();
            Console.WriteLine(details);
            //var details = _Db.Cart.ToList();
            return View(details);
        }

        public IActionResult PlaceOrder(int id)
        {
            var data = id;
            return RedirectToAction("makeorder","home",new { id=data });
            //return RedirectToAction("MakeOrder","home",id);
        }

        public IActionResult RemoveCartItem(int id)
        {
            var datas = _Db.Cart.Where(data=>data.User.Contains(HttpContext.Session.GetString("UserName")) && data.Id==id).ToList();
            foreach (var data in datas)
                _Db.Cart.Remove(data);
            _Db.SaveChanges();
          
            return RedirectToAction("CartItem");
        }


    }
}
