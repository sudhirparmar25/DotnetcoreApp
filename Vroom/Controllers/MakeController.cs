using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vroom.Models;
namespace Vroom.Controllers
{
    public class MakeController : Controller
    {
        public IActionResult Bikes()
        {
            Make make = new Make { Id = 1, Name = "Harley davidson" };

            return View(make);
        }
    }
}
