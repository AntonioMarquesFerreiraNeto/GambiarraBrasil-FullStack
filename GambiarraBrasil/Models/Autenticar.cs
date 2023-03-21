using System.ComponentModel.DataAnnotations;

namespace GambiarraBrasil.Models {
    public class Autenticar {

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Senha { get; set; }
    }
}
