using GambiarraBrasil.Filter;
using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Pomelo.EntityFrameworkCore.MySql.Query.Internal;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace GambiarraBrasil.Controllers {
    [PagUserAutenticado]
    public class MinhasPublicacoesController : Controller {

        private readonly UserIRepositorio _userIRepositorio;
        private readonly ArtigoIRepositorio _artigoIRepositorio;
        private readonly ISection _section;

        public MinhasPublicacoesController(UserIRepositorio userIRepositorio, ArtigoIRepositorio artigoIRepositorio, ISection section) {
            _userIRepositorio = userIRepositorio;
            _artigoIRepositorio = artigoIRepositorio;
            _section = section;
        }

        public IActionResult Index() {
            ViewData["Title"] = "Minhas publicações";
            Usuario usuario = _section.buscarSectionUser(); 
            usuario = _userIRepositorio.ListUsuarioPorId(usuario.Id);
            if (string.IsNullOrEmpty(usuario.Id.ToString())) {
                TempData["Erro"] = "Desculpe, ID não foi encontrado!";
                return RedirectToAction("Index", "Home");
            }
            return View(usuario);
        }

        public IActionResult EditArtigo(int? id) {
            ViewData["Title"] = "Editar artigo";
            Artigo artigo = _artigoIRepositorio.ListForIdArtigo(id);
            if (artigo == null) {
                TempData["Erro"] = "Desculpe, ID não foi encontrado!";
                return View(artigo);
            }
            return View(artigo);
        }

        [HttpPost]
        public IActionResult EditArtigo(Artigo artigo) {
            try {
                ViewData["Title"] = "Editar artigo";
                if (ModelState.IsValid) {
                    _artigoIRepositorio.EditarArtigo(artigo);
                    TempData["Sucesso"] = "Atualizado com sucesso!";
                    return RedirectToAction("Index");
                }
                TempData["Erro"] = "Ops, observe os campos para saber o problema!";
                return View(artigo);
            }
            catch (Exception error) {
                TempData["Erro"] = error.Message;
                return View(artigo);
            }
        }

        public IActionResult DropGetArtigo(int? id) {
            Artigo artigo = _artigoIRepositorio.ListForIdArtigo(id);
            return PartialView("_Excluir", artigo);
        }

        [HttpPost]
        public IActionResult ExcluirArtigo(Artigo artigo) {
            try {
                _artigoIRepositorio.Excluir(artigo);
                TempData["Sucesso"] = "Deletado com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception error) {
                TempData["Erro"] = error.Message;
                return RedirectToAction("Index");
            }
        }
    }
}
