using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class MakeController : Controller
    {
        private readonly VroomDBContext _context;
        public MakeController(VroomDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Makes.ToList());
        }

        public IActionResult Demo()
        {
            return View();
        }
        public IActionResult Demo1()
        {
            return View();
        }
  
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Make make)
        {
            if (ModelState.IsValid)
            {
                _context.Add(make);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(make);
           
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var make = _context.Makes.Find(id);
            if (make == null)
            {
                return NotFound();
            }
            _context.Makes.Remove(make);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int id)
        {
            var make = _context.Makes.Find(id);
            if (make == null)
            {
                return NotFound();
            }
            _context.SaveChanges();
            return View(make);
        }
        [HttpPost]
        public IActionResult Update(Make make)
        {
            if (ModelState.IsValid)
            {
                var makedata = _context.Makes.Find(make.Id);
                _context.Update(makedata);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(make);
        }
    }
}
