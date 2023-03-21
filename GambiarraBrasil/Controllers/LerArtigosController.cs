﻿using GambiarraBrasil.Filter;
using Microsoft.AspNetCore.Mvc;

namespace GambiarraBrasil.Controllers {
    [PagUserAutenticado]
    public class LerArtigosController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
