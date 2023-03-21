using GambiarraBrasil.Models;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GambiarraBrasil.Controllers {
    public class RegistroUserController : Controller {

        private readonly UserIRepositorio _repositorioRegistroUser;

        public RegistroUserController(UserIRepositorio repositorioRegistroUser) {
            _repositorioRegistroUser = repositorioRegistroUser;
        }

        public IActionResult Index() {
            ViewData["Title"] = "Novo usuário";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Usuario usuario) {
            try {
                if (ModelState.IsValid) {
                    _repositorioRegistroUser.CreateUser(usuario);
                    TempData["Sucesso"] = "Registrado com sucesso!";
                    return RedirectToAction("Index", "Logar");
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
