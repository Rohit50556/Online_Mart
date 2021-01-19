using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using online_mart.Models;
using online_mart.ViewModels;
using System;
using System.Threading.Tasks;
namespace online_mart.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserClass nec)
        {
            if (ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel obj)
        {
            var getdetails = await _db.UserTable.FindAsync(obj.PhoneNumber);
            if (getdetails == null)
            {
                ViewBag.Error = "User Not Found Please Create New Accout";
                return View();
            }
            else if (getdetails.PhoneNumber == null)
            {
                ViewBag.Error = "User Not Found Please Create New Accout";
                return View();

            }
            else if (getdetails.PhoneNumber == obj.PhoneNumber)
            {
                HttpContext.Session.SetString("UserName", obj.PhoneNumber);
                if (getdetails.Password == obj.Password)
                {
                    HttpContext.Session.SetString("Address", getdetails.Address);
                    HttpContext.Session.SetString("UserInfo", getdetails.Name);
                    //HttpContext.Session.GetString("Address");

                    //  Console.WriteLine(HttpContext.Session.GetString("UserName"));
                    // Console.WriteLine("Login");
                    return RedirectToAction("HomePage", "home");
                }
                else
                {
                    ViewBag.Error = "Enter Valid Password";
                    return View();
                }
            }
            else
            {
                ViewBag.Error = "Enter Valid PhoneNumber";
                return View();
            }
        }
        public async Task<IActionResult> ForgotPassword()
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return RedirectToAction("login");
            }

            var getdetails = await _db.UserTable.FindAsync(HttpContext.Session.GetString("UserName"));
            HttpContext.Session.SetString("row1", getdetails.Name);
            HttpContext.Session.SetString("row3", getdetails.Email);
            HttpContext.Session.SetString("row4",getdetails.Address);

            return View(getdetails);
        }

        [HttpPost]

        public async Task<IActionResult> ForgotPassword(RegisterUserClass data)
        {

            data.Name = HttpContext.Session.GetString("row1");
            data.Email = HttpContext.Session.GetString("row3");
            data.Address= HttpContext.Session.GetString("row4");

            _db.Update(data);
            await _db.SaveChangesAsync();
            return View("Login");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("HomePage", "home");
        }
    }
}
