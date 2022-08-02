using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.Controllers
{
    public class ModelController : Controller
    {
        private readonly VroomDBContext _context;
        public ModeViewModel ModelVM { get; set; }

        public ModelController(VroomDBContext context)
        {
            _context = context;
            ModelVM = new ModeViewModel()
            {
                Makes = _context.Makes.ToList(),
                Model = new Models.Model()
            };
        }
        public IActionResult Index()
        {
            var model = _context.Models.Include(m => m.Make);
            return View(model);
        }
        public IActionResult Add()
        {
            return View(ModelVM);
        }
        [HttpPost,ActionName("Add")]
        public IActionResult AddPost(Model model)
        {
            if (!ModelState.IsValid)
            {
                return View(ModelVM);
            }
            _context.Models.Add(model);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int id)
        {
            ModelVM.Model = _context.Models.Include(m => m.Make).SingleOrDefault(m => m.Id == id);
            if (ModelVM.Model == null)
            {
                return NotFound();
            }
            return View(ModelVM);
        }
        [HttpPost,ActionName("Update")]
        public IActionResult UpdatePost(ModeViewModel modelw)
        {
            if (ModelVM.Model == null)
            {
                return NotFound();
            }
            Model modeldata = _context.Models.Find(modelw.Model.Id);
            modeldata.Name = modelw.Model.Name;
            modeldata.MakeId = modelw.Model.MakeId;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
