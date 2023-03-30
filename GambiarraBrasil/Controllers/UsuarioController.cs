using GambiarraBrasil.Filter;
using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace GambiarraBrasil.Controllers {
    [PagUserAutenticado]
    public class UsuarioController : Controller {

        private readonly ISection _section;
        private readonly UserIRepositorio _userIRepositorio;

        public UsuarioController(ISection section, UserIRepositorio userIRepositorio) {
            _section = section;
            _userIRepositorio = userIRepositorio;
        }
        public IActionResult Index() {
            ViewData["Title"] = "Editar usuário";
            Usuario usuario = _section.buscarSectionUser();
            usuario = _userIRepositorio.ListUsuarioPorIdNoJoin(usuario.Id);
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Index(Usuario usuario) {
            ViewData["Title"] = "Editar usuário";
            try {
                if (ModelState.IsValid) {
                    _userIRepositorio.UpdateUser(usuario);
                    TempData["Sucesso"] = "Usuário editado com sucesso!";
                    return View(usuario);
                }
                TempData["Erro"] = "Ops, observe os campos para saber o problema!";
                return View(usuario);
            }
            catch (Exception error) {
                TempData["Erro"] = error.Message;
                return View(usuario);
            }
        }

        public IActionResult ReturnModalSenha() {
            Usuario usuario = _section.buscarSectionUser();
            MudarSenha mudarSenha = PopularUser(usuario);
            return PartialView("_EditSenha", mudarSenha);
        }

        [HttpPost]
        public IActionResult MudarSenha(MudarSenha mudarSenha) {
            try {
                if (string.IsNullOrEmpty(mudarSenha.SenhaAtual) || string.IsNullOrEmpty(mudarSenha.NovaSenha) || string.IsNullOrEmpty(mudarSenha.ConfirmarSenha)) {
                    TempData["Erro"] = "Desculpe, mas os campos são obrigatórios para atualizar a senha!";
                    return RedirectToAction("Index");
                }
                else {
                    if (mudarSenha.ValNovaSenhaConfirmSenha()) {
                        TempData["Erro"] = "Nova senha e confirmar senha não são iguais!";
                        return RedirectToAction("Index");
                    }
                    _userIRepositorio.UpdateSenha(mudarSenha);
                    TempData["Sucesso"] = "Senha alterada com sucesso!";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception error) {
                TempData["Erro"] = error.Message;
                return RedirectToAction("Index");
            }
        }




        public MudarSenha PopularUser(Usuario value) {
            MudarSenha mudarSenha = new MudarSenha();
            mudarSenha.Id = value.Id;
            return mudarSenha;
        }
    }
}
