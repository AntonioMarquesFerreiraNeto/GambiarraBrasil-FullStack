using GambiarraBrasil.Filter;
using GambiarraBrasil.Models;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GambiarraBrasil.Controllers {
    [PagUserAutenticado]
    public class LerArtigosController : Controller {
        private readonly ArtigoIRepositorio _artigoRepositorio;

        public LerArtigosController(ArtigoIRepositorio artigoIRepositorio) {
            _artigoRepositorio = artigoIRepositorio;
        }
        public IActionResult Index() {
            ViewData["Title"] = "Ler artigos";
            List<Artigo> artigos = _artigoRepositorio.ListArtigos();
            return View(artigos);
        }

        public IActionResult Artigo(int? id) {
            if (string.IsNullOrEmpty(id.ToString())) {
                TempData["Erro"] = "Desculpe, ID não foi encontrado!";
                return RedirectToAction("Index");
            }
            Artigo artigo  = _artigoRepositorio.ListForIdArtigo(id);
            ViewData["Title"] = artigo.Titulo;
            return View(artigo);
        }
    }
}
