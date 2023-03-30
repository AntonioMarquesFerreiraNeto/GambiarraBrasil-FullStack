using GambiarraBrasil.Models;
using GambiarraBrasil.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GambiarraBrasil.ViewComponents {
    public class Menu : ViewComponent {

        private readonly UserIRepositorio _userIRepositorio;

        public Menu(UserIRepositorio userIRepositorio) {
            _userIRepositorio = userIRepositorio;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            string sectionUser = HttpContext.Session.GetString("sectionUserAutenticado");

            if (string.IsNullOrEmpty(sectionUser)) {
                return null;
            }
            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(sectionUser);
            usuario = _userIRepositorio.ListUsuarioPorIdNoJoin(usuario.Id);
            return View(usuario);
        }
    }
}
