using GambiarraBrasil.Filter;
using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GambiarraBrasil.Controllers {
    public class RegistroUserController : Controller {

        private readonly UserIRepositorio _repositorioRegistroUser;
        private readonly ISection _section;

        public RegistroUserController(UserIRepositorio repositorioRegistroUser, ISection section) {
            _repositorioRegistroUser = repositorioRegistroUser;
            _section = section;
        }

        public IActionResult Index() {
            ViewData["Title"] = "Novo usuário";
            if (_section.buscarSectionUser() != null) {
                TempData["Erro"] = "Ops! Para registrar um novo perfil, é necessário sair do sistema!";
                return RedirectToAction("Index", "Home");
            }
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
