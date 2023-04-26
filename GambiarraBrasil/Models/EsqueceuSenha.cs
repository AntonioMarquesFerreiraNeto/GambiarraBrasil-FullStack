using System.ComponentModel.DataAnnotations;

namespace GambiarraBrasil.Models {
    public class EsqueceuSenha {

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Tel { get; set; }
    }
}
