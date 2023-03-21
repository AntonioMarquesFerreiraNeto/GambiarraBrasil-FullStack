using GambiarraBrasil.Models;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GambiarraBrasil.Controllers {
    public class LogarController : Controller {
        
        private readonly UserIRepositorio _userRepositorio;

        public LogarController(UserIRepositorio userRepositorio) {
            _userRepositorio = userRepositorio;
        }

        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Autenticar usuario) {
            try {
                if (ModelState.IsValid) {
                    _userRepositorio.ValidarCredenciais(usuario);
                    return RedirectToAction("Index", "Home");
                }
                return View(usuario);
            }
            catch (Exception error) {
                TempData["Erro"] = error.Message;
                return View(usuario);
            }
        }
    }
}
