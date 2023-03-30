using System.ComponentModel.DataAnnotations;

namespace GambiarraBrasil.Models {
    public class MudarSenha {
        public int Id { get; set; }

        public string SenhaAtual { get; set; }

        public string NovaSenha { get; set; }

        public string ConfirmarSenha { get; set; }

        public bool ValNovaSenhaConfirmSenha() {
            bool result = (ConfirmarSenha != NovaSenha) ? true : false;
            return result;
        }
    }
}
