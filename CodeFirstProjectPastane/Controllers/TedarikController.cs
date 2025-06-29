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
    public class TedarikController : Controller
    {
        private readonly AppDbContext _context;

        public TedarikController(AppDbContext context)
        {
            _context = context;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var tedarikci = _context.Tedarikcis.ToList();
            return View(tedarikci);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var update = _context.Tedarikcis.Find(id);
            return View(update);
        }

        [HttpPost]
        public IActionResult Edit(int id, Tedarikci tedarikci)
        {
            _context.Update(tedarikci);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var tedarikci = _context.Tedarikcis.Find(id);
            if (tedarikci != null)
            {
                Task.Delay(3000);
                _context.Remove(tedarikci);
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
        public IActionResult Create(Tedarikci tedarikci)
        {
            if (ModelState.IsValid)
            {
                _context.Tedarikcis.Add(tedarikci);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tedarikci);
        }
    }
}

