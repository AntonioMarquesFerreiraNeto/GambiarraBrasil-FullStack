using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models.ValidationsModels;
using System.ComponentModel.DataAnnotations;

namespace GambiarraBrasil.Models {
    public class Usuario {

        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        //[ValidarForcaSenha(CaracterEspecialRequerido = true, SenhaForteRequerida = true, SenhaTamanhoMinimo = 5, ErrorMessage = "A senha deve conter letras, números e caractéres especiais!")]
        public string SenhaUser { get; set; }

        public void CriptografarSenha() {
            SenhaUser = Criptografia.GerarHash(SenhaUser);
        }
    }
}
