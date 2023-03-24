using GambiarraBrasil.Filter;
using Microsoft.AspNetCore.Mvc;

namespace GambiarraBrasil.Controllers {
    [PagUserAutenticado]
    public class DoarController : Controller {
        public IActionResult Index() {
            ViewData["Title"] = "Doar";
            return View();
        }
    }
}
