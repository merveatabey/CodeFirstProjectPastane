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
    public class DepartmanController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmanController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var departman = _context.Departmans.ToList();
            return View(departman);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var update = _context.Departmans.Find(id);
            return View(update);
        }

        [HttpPost]
        public IActionResult Edit(int id, Departman departman)
        {
            _context.Update(departman);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var departman = _context.Departmans.Find(id);
            if (departman != null)
            {
                _context.Remove(departman);
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
        public IActionResult Create(Departman departman)
        {
            if (ModelState.IsValid)
            {
                _context.Departmans.Add(departman);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(departman);
        }
    }
}

