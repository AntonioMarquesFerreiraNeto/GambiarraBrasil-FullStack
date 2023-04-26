using System.ComponentModel.DataAnnotations;

namespace GambiarraBrasil.Models {
    public class RedefinirSenha {

        public string Token { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string NovaSenha { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string ConfirmarSenha { get; set; }

        public bool ValidationPassConfirmPass() {
            if (NovaSenha.Trim() == ConfirmarSenha.Trim()) {
                return true;
            }
            return false;
        }
    }
}
