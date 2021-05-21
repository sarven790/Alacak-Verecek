using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AlacakVerecekTakip.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using AlacakVerecekTakip.Filter;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace AlacakVerecekTakip.Controllers
{ 
    [UserFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Context c = new Context();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int s=1)
        {
            int id = (int)HttpContext.Session.GetInt32("id");
            var degerler = c.cariHesaplarTablosu.Where(x => x.uyelerTablosu.ID == id && x.Durum == true).ToList().ToPagedList(s, 4);
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniCariEkle()
        {

            int id = (int)HttpContext.Session.GetInt32("id");
            List<SelectListItem> degerler = (from i in c.uyelerTablosu.ToList()
                                             select new SelectListItem
                                             {

                                                 Text=i.KulAdi,
                                                 Value=id.ToString()

                                             }).ToList();

            ViewBag.dgr = degerler;

            return View();
        }
        [HttpPost]
        public IActionResult YeniCariEkle(CariHesaplarTablosu h)
        {
            var uye = c.uyelerTablosu.Where(x => x.ID == h.uyelerTablosu.ID).FirstOrDefault();
            h.uyelerTablosu = uye;
            c.cariHesaplarTablosu.Add(h);
            c.SaveChanges();
            return Redirect("/Home/Index/");
        }
       
        public IActionResult AlacakGetir(int ID)
        {

            var cari = c.cariHesaplarTablosu.Find(ID);
            return View("AlacakGetir",cari);

        }
        public IActionResult AlacakEkle(CariHesaplarTablosu h)
        {

            decimal bkye = 0;

            var alacak = c.cariHesaplarTablosu.Find(h.ID);
            decimal alacakm = Convert.ToDecimal(alacak.AlacakMiktar) + Convert.ToDecimal(h.AlacakMiktar);
            alacak.AlacakMiktar = alacakm;

            if (alacakm > alacak.VerecekMiktar)
                alacak.AlacakVerecek = "Alacaklı";
            else
                alacak.AlacakVerecek = "Verecekli";

            KasaTablosu k = new KasaTablosu();
            int id = (int)HttpContext.Session.GetInt32("id");
            
            k.UyeID = id;
            k.IslemTuru = "Alacak";
            string isim = alacak.Ad + " " + alacak.Soyad;
            k.KisiAdSoyad = isim;
            k.CikisTutari = h.AlacakMiktar;

            List<KasaTablosu> kas = new List<KasaTablosu>();

            kas = c.kasaTablosu.Where(x => x.UyeID == id).ToList();

            bkye = decimal.Parse(kas.OrderByDescending(x => x.ID).Select(x => x.Bakiye).FirstOrDefault().ToString());    

            k.Bakiye = Convert.ToDecimal(bkye) - Convert.ToDecimal(h.AlacakMiktar);

            c.kasaTablosu.Add(k);

            c.SaveChanges();

            return Redirect("/Home/Index/");

        }
        public IActionResult VerecekGetir(int ID)
        {

            var cari = c.cariHesaplarTablosu.Find(ID);
            return View("VerecekGetir", cari);

        }
        public IActionResult VerecekEkle(CariHesaplarTablosu h)
        {
            decimal bkye = 0;
            var verecek = c.cariHesaplarTablosu.Find(h.ID);
            decimal verecekm = Convert.ToDecimal(verecek.VerecekMiktar) + Convert.ToDecimal(h.VerecekMiktar);
            verecek.VerecekMiktar = verecekm;

            if (verecekm > verecek.AlacakMiktar)
                verecek.AlacakVerecek = "Verecekli";
            else
                verecek.AlacakVerecek = "Alacaklı";

            KasaTablosu k = new KasaTablosu();
            int id = (int)HttpContext.Session.GetInt32("id");

            k.UyeID = id;
            k.IslemTuru = "Verecek";
            string isim = verecek.Ad + " " + verecek.Soyad;
            k.KisiAdSoyad = isim;
            k.GirisTutari = h.VerecekMiktar;

            List<KasaTablosu> kas = new List<KasaTablosu>();

            kas = c.kasaTablosu.Where(x => x.UyeID == id).ToList();

            bkye = decimal.Parse(kas.OrderByDescending(x => x.ID).Select(x => x.Bakiye).FirstOrDefault().ToString());

            k.Bakiye = Convert.ToDecimal(bkye) + Convert.ToDecimal(h.VerecekMiktar);

            c.kasaTablosu.Add(k);

            c.SaveChanges();

            return Redirect("/Home/Index/");

        }
        public IActionResult GuncelleGetir(int ID)
        {

            var cari = c.cariHesaplarTablosu.Find(ID);
            return View("GuncelleGetir", cari);

        }
        public IActionResult Guncelle(CariHesaplarTablosu h)
        {

            var gun = c.cariHesaplarTablosu.Find(h.ID);

            gun.Ad = h.Ad;
            gun.Soyad = h.Soyad;
            gun.Telefon = h.Telefon;
            gun.Adres = h.Adres;

            c.SaveChanges();

            return Redirect("/Home/Index/");

        }
        public IActionResult Alacaklarim(int s=1)
        {

            int id = (int)HttpContext.Session.GetInt32("id");
            var degerler = c.cariHesaplarTablosu.Where(x => x.uyelerTablosu.ID == id && x.Durum == true && x.AlacakVerecek == "Alacaklı").ToList().ToPagedList(s, 4);
            return View(degerler);

        }
        public IActionResult Vereceklerim(int s=1)
        {

            int id = (int)HttpContext.Session.GetInt32("id");
            var degerler = c.cariHesaplarTablosu.Where(x => x.uyelerTablosu.ID == id && x.Durum == true && x.AlacakVerecek == "Verecekli").ToList().ToPagedList(s, 4);
            return View(degerler);

        }
        public IActionResult Kasa(int s=1)
        {

            int id = (int)HttpContext.Session.GetInt32("id");
            var degerler = c.kasaTablosu.Where(x => x.UyeID == id).ToList().ToPagedList(s, 4);
            return View(degerler);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
