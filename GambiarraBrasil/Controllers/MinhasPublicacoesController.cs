using GambiarraBrasil.Filter;
using GambiarraBrasil.Models;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace GambiarraBrasil.Controllers {
    [PagUserAutenticado]
    public class MinhasPublicacoesController : Controller {

        private readonly UserIRepositorio _userIRepositorio;

        public MinhasPublicacoesController(UserIRepositorio userIRepositorio) {
            _userIRepositorio = userIRepositorio;
        }

        public IActionResult Index(int? id) {
            Usuario usuario = _userIRepositorio.ListUsuarioPorId(id);
            if (string.IsNullOrEmpty(id.ToString())) {
                TempData["Erro"] = "Desculpe, ID não foi encontrado!";
                return RedirectToAction("Index", "Home");
            }
            return View(usuario);
        }
    }
}
