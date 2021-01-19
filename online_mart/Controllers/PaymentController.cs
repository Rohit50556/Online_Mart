using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using online_mart.Models;
using online_mart.ViewModels;
using Microsoft.AspNetCore.Http;

namespace online_mart.Controllers
{
    public class PaymentController : Controller
    {
        public readonly netBankingDbContext _db;
        public PaymentController(netBankingDbContext db)
        {
            _db = db;
        }

        public IActionResult netBanking()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> netBanking(netBankingClass obj)
        {
                //var getdetails=_db.CreditCard.Where(data=>data.)

            var getdetails = await _db.CreditCard.FindAsync(obj.CardNo);
            var price= (int)HttpContext.Session.GetInt32("price");
            if (getdetails == null)
            {
                ViewBag.Error = "Enter Valid Account Number";
                return View();
            }
            else if (getdetails.Balance < price)
            {
                ViewBag.Error = "Insufficient Balance";
                return View();
            }
            else if (!getdetails.CVV.Equals(obj.CVV))
            {
                ViewBag.Error = "Enter Valid CVV";
                return View();
            }
            else if (!getdetails.Expiration.Equals(obj.Expiration))
            {
                ViewBag.Error = "Enter Valid Expiration Date";
                return View();
            }
            else
            {
                getdetails.Balance = getdetails.Balance - price;
                _db.Update(getdetails);
                await _db.SaveChangesAsync();
                return RedirectToAction("Done_netBanking", "Order");
            }
        }

    }
}
