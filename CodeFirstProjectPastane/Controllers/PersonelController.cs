using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstProjectPastane.Data;
using CodeFirstProjectPastane.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeFirstProjectPastane.Controllers
{
    public class PersonelController : Controller
    {
        private readonly AppDbContext _context;

        public PersonelController(AppDbContext context)
        {
            _context = context;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var personel = _context.Personels.Include("Departman").ToList();
            return View(personel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var update = _context.Personels.Find(id);
            return View(update);
        }

        [HttpPost]
        public IActionResult Edit(int id, Personel personel)
        {
            _context.Update(personel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var personel = _context.Personels.Find(id);
            if (personel != null)
            {
                Task.Delay(3000);
                _context.Remove(personel);
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
        public IActionResult Create(Personel personel)
        {
            if (ModelState.IsValid)
            {
                _context.Personels.Add(personel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personel);
        }
    }
}

