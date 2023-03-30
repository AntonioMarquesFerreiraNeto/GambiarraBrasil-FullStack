using GambiarraBrasil.Helpers;
using GambiarraBrasil.Models.ValidationsModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GambiarraBrasil.Models {
    public class Usuario {

        public int Id { get; set; }

        [Required (ErrorMessage = "Campo obrigatório!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Phone { get; set; }

        public string SenhaUser { get; set; }

        public void CriptografarSenha() {
            SenhaUser = Criptografia.GerarHash(SenhaUser);
        }

        public virtual List<Artigo> Artigos { get; set; }
    }
}
