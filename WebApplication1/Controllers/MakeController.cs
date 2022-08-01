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
    }
}
