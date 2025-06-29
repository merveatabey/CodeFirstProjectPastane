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
    public class MusteriController : Controller
    {
        private readonly AppDbContext _context;

        public MusteriController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var musteri = _context.Musteris.ToList();
            return View(musteri);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var update = _context.Musteris.Find(id);
            return View(update);
        }

        [HttpPost]
        public IActionResult Edit(int id, Musteri musteri)
        {
            _context.Update(musteri);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var musteri = _context.Musteris.Find(id);
            if (musteri != null)
            {
                _context.Remove(musteri);
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
        public IActionResult Create(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                _context.Musteris.Add(musteri);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(musteri);
        }
    }
}

