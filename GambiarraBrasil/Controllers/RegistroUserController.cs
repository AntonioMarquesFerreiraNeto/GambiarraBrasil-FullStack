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
        public IActionResult Index(RegistroUser user) {
            try {
                if (ModelState.IsValid) {
                    if (user.SenhaUser.Trim() != user.ConfirmarSenha.Trim()) {
                        TempData["Erro"] = $"Sua senha e “Confirmar senha“ não são iguais!";
                        return View(user);
                    }
                    _repositorioRegistroUser.CreateUser(user);
                    TempData["Sucesso"] = "Registrado com sucesso!";
                    return RedirectToAction("Index", "Logar");
                }
                return View(user);
            }
            catch (Exception error) {
                TempData["Erro"] = error.Message;
                return View(user);
            }
        }
    }
}
