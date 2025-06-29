using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstProjectPastane.Data;
using CodeFirstProjectPastane.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirstProjectPastane.Controllers
{
    public class UrunController : Controller
    {
        private readonly AppDbContext _context;
        public UrunController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var urunler = _context.Uruns.ToList();

            return View(urunler);

        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var update = _context.Uruns.Find(id);

            var kategoriler = _context.Uruns.Select(u => u.Kategori).Distinct().ToList();
            ViewBag.Kategori = kategoriler;

            return View(update);
        }

        [HttpPost]
        public IActionResult Edit(int id, Urun urun)
        {
            _context.Update(urun);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var urun = _context.Uruns.Find(id);
            if (urun != null)
            {
                Task.Delay(3000);
                _context.Remove(urun);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Urun urun)
        {
            if (ModelState.IsValid)
            {
                _context.Uruns.Add(urun);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(urun);
        }
    }
}

