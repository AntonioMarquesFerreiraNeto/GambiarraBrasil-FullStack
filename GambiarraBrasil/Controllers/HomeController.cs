using GambiarraBrasil.Filter;
using GambiarraBrasil.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GambiarraBrasil.Controllers {
    [PagUserAutenticado]
    public class HomeController : Controller {

        public IActionResult Index() {
            ViewData["Title"] = "Home";
            return View();
        }
    }
}
