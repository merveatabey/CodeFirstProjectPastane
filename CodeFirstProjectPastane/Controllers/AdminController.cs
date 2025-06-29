using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstProjectPastane.Data;
using CodeFirstProjectPastane.Models;
using CodeFirstProjectPastane.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirstProjectPastane.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetRapor(string secilenRapor)
        {
            var model = new ReportViewModel
            {
                SecilenRapor = secilenRapor,
                Urunler = new List<Urun>(),
                Musteriler = new List<Musteri>(),
                Personeller = new List<Personel>()
            };
            switch (secilenRapor)
            {
                case "Kategorilere göre ürün listesi":
                    model.Urunler = _context.Uruns.OrderBy(u => u.Kategori).ToList();
                    break;

                case "toplam ürün çeşidi":
                    model.Urunler = _context.Uruns.ToList(); // Listeyi döndür, view'da count göster
                    break;

                case "toplam ürün sayısı":
                    model.Urunler = _context.Uruns.ToList(); // View'da toplam adet toplanır
                    break;

                case "Müşteri adreslerinin a-z sıralanması":
                    model.Musteriler = _context.Musteris.OrderBy(m => m.Adres).ToList();
                    break;

                case "Personel deneyimine göre büyükten küçüğe sıralanması":
                    model.Personeller = _context.Personels.Include(p => p.Departman).OrderByDescending(p => p.Deneyim).ToList();
                    break;

                case "Erkek personellerin listesi":
                    model.Personeller = _context.Personels.Include(p => p.Departman).Where(p => p.Cinsiyet.ToUpper() == "Erkek").ToList();
                    break;

                case "Kadın personellerin listesi":
                    model.Personeller = _context.Personels
                                         .Include(p => p.Departman)
                                         .Where(p => p.Cinsiyet.ToLower() == "Kadın")
                                         .ToList();
                    break;


            }
            return PartialView("_RaporPartial", model); // partial view burada önemli!
        }
    }
}

