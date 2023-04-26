using GambiarraBrasil.Filter;
using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace GambiarraBrasil.Controllers {
    public class LogarController : Controller {
        
        private readonly UserIRepositorio _userRepositorio;
        private readonly ISection _section;
        private readonly IEmail _email;

        public LogarController(UserIRepositorio userRepositorio,  ISection section, IEmail email) {
            _userRepositorio = userRepositorio;
            _section = section;
            _email = email;
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
            ViewData["Title"] = "Logar";
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

        public IActionResult EsqueceuSenha() {
            ViewData["Title"] = "Recuperação";
            return View();
        }

        [HttpPost]
        public IActionResult EsqueceuSenha(EsqueceuSenha esqueceuSenha) {
            ViewData["Title"] = "Recuperação";
            try {
                if (ModelState.IsValid) {
                    Usuario usuario = _userRepositorio.ReturnUserEmailAndPhone(esqueceuSenha);
                    if (usuario == null) {
                        TempData["Erro"] = "Desculpe, usuário não encontrado!";
                        return View(esqueceuSenha);
                    }
                    var token = usuario.Token;
                    var urlRedefinicao = Url.Action(nameof(Index), "RedefinirSenha", new { token }, Request.Scheme);
                    _email.EnviarRedefinicaoSenha(usuario, urlRedefinicao);
                    TempData["Sucesso"] = "Enviamos as orientações de recuperação de conta para seu e-mail!";
                    return RedirectToAction("Index");
                }
                return View(esqueceuSenha);
            }
            catch (Exception error) {
                TempData["Erro"] = error.Message;
                return View(esqueceuSenha);
            }
        }

        public IActionResult AcessoNegado() {
            TempData["Erro"] = "Desculpe, seu acesso foi negado!";
            return RedirectToAction("Index");
        }
    }
}
