using GambiarraBrasil.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GambiarraBrasil.ViewComponents {
    public class Menu  : ViewComponent {

        public async Task<IViewComponentResult> InvokeAsync() {
            string sectionUser = HttpContext.Session.GetString("sectionUserAutenticado");

            if (string.IsNullOrEmpty(sectionUser)) {
                return null;
            }
            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(sectionUser);
            return View(usuario);
        }
    }
}
