using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using online_mart.Models;
using Microsoft.AspNetCore.Http;

namespace online_mart.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderDbContext _db;
        //private Random rand;

        public OrderController(OrderDbContext db)
        {
           _db = db;
        }

        //Order Conformation
        public IActionResult OrderConformation(OrderClass data)
        {
                data.Address = HttpContext.Session.GetString("Address");
                data.Status = "Pending...";
                data.User = HttpContext.Session.GetString("UserName");

                HttpContext.Session.SetInt32("id", data.Id);
                HttpContext.Session.SetString("address", data.Address);
                HttpContext.Session.SetString("name", data.Name);
                HttpContext.Session.SetString("info", data.Info);
                HttpContext.Session.SetInt32("price", data.Price);
                HttpContext.Session.SetString("status", data.Status);
                HttpContext.Session.SetString("user", data.User);




                //obj = data;
                // Console.WriteLine("rc=" + data.Status + " " + data.Name + " " + data.Price + " " + data.Address + " " + data.Info);
                // Console.WriteLine("rc=" + obj.Status + " " + obj.Name + " " + obj.Price + " " + obj.Address + " " + obj.Info);

                return RedirectToAction("Payment");
            

        }
        public IActionResult Payment()
        {
            return View();
        }
        public async Task<IActionResult> CashOnDelievery()
        {
            OrderClass obj=new OrderClass();
            
            //Console.WriteLine(HttpContext.Session.GetString("name"));
            obj.Id = (int)HttpContext.Session.GetInt32("id");
            obj.Name = HttpContext.Session.GetString("name");
            obj.Info = HttpContext.Session.GetString("info");
            obj.Price = (int)HttpContext.Session.GetInt32("price");
            obj.Address = HttpContext.Session.GetString("address");
            obj.Status = "Pending...";
            obj.User = HttpContext.Session.GetString("user");
            
            _db.Add(obj);
            await _db.SaveChangesAsync();
            return RedirectToAction("Order");
        }

        public async Task<IActionResult> Done_netBanking()
        {
            OrderClass obj = new OrderClass();

            //Console.WriteLine(HttpContext.Session.GetString("name"));
            obj.Id = (int)HttpContext.Session.GetInt32("id");
            obj.Name = HttpContext.Session.GetString("name");
            obj.Info = HttpContext.Session.GetString("info");
            obj.Price = (int)HttpContext.Session.GetInt32("price");
            obj.Address = HttpContext.Session.GetString("address");
            obj.Status = "Done";
            obj.User = HttpContext.Session.GetString("user");


            _db.Add(obj);
            await _db.SaveChangesAsync();
            return RedirectToAction("order");
        }
        public IActionResult Order()
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var getdetails =_db.OrderData.Where(user=>user.User.Contains(HttpContext.Session.GetString("UserName")));
            return View(getdetails);
        }
        
    }
}
