using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlacakVerecekTakip.Models;
using Microsoft.AspNetCore.Http;

namespace AlacakVerecekTakip.Controllers
{
    public class AccountController1 : Controller
    {

        Context c = new Context();

        [HttpGet]
        public IActionResult UyeOl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UyeOl(UyelerTablosu u)
        {
            c.Add(u);
            c.SaveChanges();
            return RedirectToAction("UyeGiris");
        }
        public IActionResult login(string KulAdi,string Sifre) 
        {

            var user = c.uyelerTablosu.FirstOrDefault(x => x.KulAdi.Equals(KulAdi) && x.Sifre.Equals(Sifre));

            if (user != null)
            {
                HttpContext.Session.SetInt32("id", user.ID);
                return Redirect("/Home/Index?id="+user.ID);
            }
            
            return Redirect("/AccountController1/UyeGiris");

        }
        public IActionResult logout()
        {

            HttpContext.Session.Clear();
            return Redirect("/AccountController1/UyeGiris");

        }
        public IActionResult UyeGiris()
        {
            if(HttpContext.Session.GetInt32("id").HasValue)
            {
                return Redirect("/Home/Index?id="+HttpContext.Session.GetInt32("id"));
            }
            return View();
        }
    }
}
