using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models.ValidationsModels;
using System.ComponentModel.DataAnnotations;

namespace GambiarraBrasil.Models {
    public class Usuario {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string SenhaUser { get; set; }

        public void CriptografarSenha() {
            SenhaUser = Criptografia.GerarHash(SenhaUser);
        }
    }
}
