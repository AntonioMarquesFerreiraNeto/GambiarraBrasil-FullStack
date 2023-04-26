using GambiarraBrasil.Models;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GambiarraBrasil.Controllers {
    public class RedefinirSenhaController : Controller {

        private readonly UserIRepositorio _userIRepositorio;

        public RedefinirSenhaController(UserIRepositorio userIRepositorio) {
            _userIRepositorio = userIRepositorio;
        }

        public IActionResult Index(string token) {
            if (string.IsNullOrEmpty(token)) {
                TempData["Erro"] = "Desculpe, seu acesso foi negado!";
                return RedirectToAction("Index", "Logar");
            }
            ViewData["Title"] = "Redefinir senha";
            return View();
        }

        [HttpPost]
        public IActionResult Index(RedefinirSenha redefinirSenha) {
            ViewData["Title"] = "Redefinir senha";
            try {
                if (ModelState.IsValid) {
                    if (string.IsNullOrEmpty(redefinirSenha.Token)) {
                        TempData["Erro"] = "Ação inválida!";
                        return RedirectToAction("Index");
                    }
                    if (!redefinirSenha.ValidationPassConfirmPass()) {
                        TempData["Erro"] = "Nova senha e confirmar senha não são iguais!";
                        return View(redefinirSenha);
                    }
                    _userIRepositorio.RedefinirSenha(redefinirSenha);
                    TempData["Sucesso"] = "Senha redefinida com sucesso!";
                    return RedirectToAction("Index", "Logar");
                }
                return View(redefinirSenha);
            }
            catch (Exception error) {
                TempData["Erro"] = error.Message;
                return View();
            }
        }
    }
}
