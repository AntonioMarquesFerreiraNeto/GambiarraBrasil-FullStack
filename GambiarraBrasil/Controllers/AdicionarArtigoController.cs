using GambiarraBrasil.Filter;
using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models;
using GambiarraBrasil.Models.ViewModels;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GambiarraBrasil.Controllers {
    [PagUserAutenticado]
    public class AdicionarArtigoController : Controller {

        private readonly ISection _section;
        private readonly ArtigoIRepositorio _artigoIRepositorio;

        public AdicionarArtigoController(ISection section, ArtigoIRepositorio artigoIRepositorio) {
            _section = section;
            _artigoIRepositorio = artigoIRepositorio;
        }

        public IActionResult Index() {
            ViewData["Title"] = "Adicionar artigos";
            return View();
        }

        public IActionResult ArtigoAdd() {
            ViewData["Title"] = "Novo artigo";
            Artigo artigo = new Artigo();
            artigo.Usuario = _section.buscarSectionUser();
            return View(artigo);
        }

        [HttpPost]
        public IActionResult ArtigoAdd(Artigo artigo) {
            try {
                if (ModelState.IsValid) {
                    TempData["Sucesso"] = "Adicionado com sucesso!";
                    _artigoIRepositorio.NovoArtigo(artigo);
                    return View(artigo);
                }
                TempData["Erro"] = "Informe os campos obrigatórios!";
                return View(artigo);
            }
            catch (Exception error) {
                TempData["Erro"] = error.Message;
                return View(artigo);
            }
        }
    }
}
