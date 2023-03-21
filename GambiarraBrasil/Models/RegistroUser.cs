using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models.ValidationsModels;
using System.ComponentModel.DataAnnotations;

namespace GambiarraBrasil.Models {
    public class RegistroUser {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        //[ValidarForcaSenha(CaracterEspecialRequerido = true, SenhaForteRequerida = true, SenhaTamanhoMinimo = 5, ErrorMessage = "Nível de complexidade abaixo do esperado!")]
        public string SenhaUser { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string ConfirmarSenha { get; set; }
    }
}
