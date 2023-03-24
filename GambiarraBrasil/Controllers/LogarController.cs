using GambiarraBrasil.Filter;
using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace GambiarraBrasil.Controllers {
    public class LogarController : Controller {
        
        private readonly UserIRepositorio _userRepositorio;
        private readonly ISection _section;

        public LogarController(UserIRepositorio userRepositorio,  ISection section) {
            _userRepositorio = userRepositorio;
            _section = section;
        }

        public IActionResult Index() {
            ViewData["Title"] = "Logar";
            if (_section.buscarSectionUser() != null) {
                TempData["Erro"] = "Ops, tentou sair pela URL!";
                return RedirectToAction("Index", "Home");
            } 
            return View();
        }

        [HttpPost]
        public IActionResult Index(Autenticar usuario) {
            try {
                if (ModelState.IsValid) {
                    Usuario usuarioRetornado = _userRepositorio.ValidarCredenciais(usuario);
                    _section.CriarSection(usuarioRetornado);
                    return RedirectToAction("Index", "Home");
                }
                return View(usuario);
            }
            catch (Exception error) {
                TempData["Erro"] = error.Message;
                return View(usuario);
            }
        }

        public IActionResult Sair() {
            try {
                _section.EncerrarSection();
                return RedirectToAction("Index", "Logar");
            }
            catch (Exception error) {
                TempData["Erro"] = error.Message;
                return RedirectToAction("Index", "Home");
            }
        }


        public IActionResult AcessoNegado() {
            TempData["Erro"] = "Desculpe, seu acesso foi negado!";
            return RedirectToAction("Index");
        }
    }
}
